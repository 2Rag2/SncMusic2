using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;

namespace SncMusic
{
    public class Usuario
    {
        // atributos e propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }

        //Métodos construtores (new curso())
        public Usuario()
        {

        }
        public Usuario (int _Id,string _nome, string _email, string _senha, string _situacao)
        {

            Id = _Id;
            Nome = _nome;
            Senha = _senha;
            Situacao = _situacao;
            Email = _email;
        }
        public Usuario (string nome, string email, string senha, string situacao)
        {
            Nome = nome;
            Senha = senha;
            Situacao = situacao;
            Email = email;

        }
        //métodos da classe
        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_usuario values (0,@nome,@email,@senha,@situacao)";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = Situacao;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }
        public bool alterar(Usuario usuario)
        {
            try //Bloco de tratamento de excessão
            {
                var comm = Banco.Abrir();
                comm.CommandText = "update tb_usuario set nome_usuario = @nome,email_usuario = @email, senha_usuario = @senha, situacao_usuario = @situacao)";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
                comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email;
                comm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
                comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = usuario.Situacao;
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                Banco.Fechar();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }
        public void ConsultarPorId(int _id)
        {
            //Consultar o Aluno
            var comm = Banco.Abrir();
            comm.CommandText = "select * from tb_usuario where id_usuario = " + _id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Situacao = dr.GetString(4);
               
            }
            //Banco.Fechar();

        }
        public MySqlDataReader ListarTodos()
        {
            MySqlDataReader dr;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_usuario";
                dr = comm.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
                return dr = null;
            }
        }
    }
}

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
    public class Aluno
    {
        // atributos e propriedades
        public int id { get; set; }
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Cpf { get; internal set; }



        // metodos construtores
        public Aluno(int _id, string _nome, string _email, string _cpf, string _sexo, string _telefone, DateTime _dataCadastro)
        {
            id = _id;
            Nome = _nome;
            cpf = _cpf;
            sexo = _sexo;
            Telefone = _telefone;
            DataCadastro = _dataCadastro;
            Email = _email;

        }
        public Aluno(string _nome, string _email, string _cpf, string _sexo, string _telefone)
        {

            Nome = _nome;
            cpf = _cpf;
            sexo = _sexo;
            Telefone = _telefone;
            Email = _email;

        }
        public Aluno(int _id, string _nome, string _sexo, string _telefone)
        {

            Nome = _nome;
            sexo = _sexo;
            Telefone = _telefone;
            id = _id;

        }
        public Aluno()
        {

            
        }
        //métodos da classe
        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_aluno values (0,@nome,@cpf,@sexo,@email,@telefone,default)";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = sexo;
            comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = Telefone;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }
        public bool alterar(Aluno aluno)
        {
            try //Bloco de tratamento de excessão
            { 
                var comm = Banco.Abrir();
            comm.CommandText = "update tb_aluno set nome_aluno = @nome,sexo_aluno = @sexo,telefone_aluno = @telefone where id_aluno = @id";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = aluno.Nome;
            comm.Parameters.Add("@id", MySqlDbType.VarChar).Value = aluno.id;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = aluno.sexo;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = aluno.Telefone;
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
            comm.CommandText = "select * from tb_aluno where id_aluno = " + _id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Nome = dr.GetString(1);
                Email = dr.GetString(4);
                Cpf = dr.GetString(2);
                sexo = dr.GetString(3);
                Telefone = dr.GetString(5);
                DataCadastro = Convert.ToDateTime(dr.GetValue(6));
            }
            //Banco.Fechar();

        }
        public List<Aluno> ListarTodos()
        {
            List<Aluno> listaAluno = new List<Aluno>();
            var comm = Banco.Abrir();
            comm.CommandText = "select * from tb_aluno where id_aluno order by 2 = ";
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                listaAluno.Add(new Aluno(dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetString(3),
                 dr.GetString(4),
                 dr.GetString(5),
                 Convert.ToDateTime(dr.GetValue(6))));

                //Aluno aluno = new Aluno();
                //aluno.id = dr.GetInt32(0);
                //aluno.Nome = dr.GetString(1);
                //aluno.Email = dr.GetString(4);
                //aluno.Cpf = dr.GetString(2);
                //aluno.sexo = dr.GetString(3);
                //aluno.Telefone = dr.GetString(5);
                //aluno.DataCadastro = Convert.ToDateTime(dr.GetValue(6));
                //listaAluno.Add(aluno);
            }
            Banco.Fechar();
            return listaAluno;

        }

    }
    
    
}

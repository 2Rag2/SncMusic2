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
    public class Professor
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
        public Professor(int _id, string _nome, string _email, string _cpf, string _sexo, string _telefone, DateTime _dataCadastro)
        {
            id = _id;
            Nome = _nome;
            cpf = _cpf;
            sexo = _sexo;
            Telefone = _telefone;
            DataCadastro = _dataCadastro;
            Email = _email;

        }
        public Professor(string _nome, string _email, string _cpf, string _telefone)
        {

            Nome = _nome;
            cpf = _cpf;        
            Telefone = _telefone;
            Email = _email;

        }
        public Professor(int _id, string _nome,string _telefone)
        {

            Nome = _nome;           
            Telefone = _telefone;
            id = _id;

        }

        public Professor(int _id, string _nome, string _cpf, string _email)
        {

            Nome = _nome;
            Cpf = _cpf;
            id = _id;
            Email = _email;

        } 

        public Professor()
        {


        }
        //métodos da classe
        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_Professor values (0,@nome,@cpf,@sexo,@email,@telefone,default)";
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
        public bool alterar(Professor Professor)
        {
            try //Bloco de tratamento de excessão
            {
                var comm = Banco.Abrir();
                comm.CommandText = "update tb_Professor set nome_Professor = @nome,sexo_Professor = @sexo,telefone_Professor = @telefone where id_Professor = @id";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Professor.Nome;
                comm.Parameters.Add("@id", MySqlDbType.VarChar).Value = Professor.id;
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = Professor.sexo;
                comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = Professor.Telefone;
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
            //Consultar o Professor
            var comm = Banco.Abrir();
            comm.CommandText = "select * from tb_Professor where id_Professor = " + _id;
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
        public List<Professor> ListarTodos()
        {
            List<Professor> listaProfessor = new List<Professor>();
            var comm = Banco.Abrir();
            comm.CommandText = "select * from tb_Professor where id_Professor order by 2 = ";
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                listaProfessor.Add(new Professor(dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetString(3),
                 dr.GetString(4),
                 dr.GetString(5),
                 Convert.ToDateTime(dr.GetValue(6))));

                //Professor Professor = new Professor();
                //Professor.id = dr.GetInt32(0);
                //Professor.Nome = dr.GetString(1);
                //Professor.Email = dr.GetString(4);
                //Professor.Cpf = dr.GetString(2);
                //Professor.sexo = dr.GetString(3);
                //Professor.Telefone = dr.GetString(5);
                //Professor.DataCadastro = Convert.ToDateTime(dr.GetValue(6));
                //listaProfessor.Add(Professor);
            }
            Banco.Fechar();
            return listaProfessor;


        }
    }
}

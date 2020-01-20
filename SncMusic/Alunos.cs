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
        public string Nome { get; set;}
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set;}
        public DateTime DataCadastro { get; set; }



        // metodos construtores
        public Aluno()
        {

        }
        public Aluno(int _id,string _nome, string _email, string _cpf,string _sexo,string _telefone, DateTime _dataCadastro)
        {
            id = _id;
            Nome = _nome;
            cpf = _cpf;
            sexo = _sexo;
            Telefone = _telefone;
            DataCadastro = _dataCadastro;
            Email = _email;

        }
        public Aluno( string _nome, string _email, string _cpf, string _sexo, string _telefone )
        {
           
            Nome = _nome;
            cpf = _cpf;
            sexo = _sexo;
            Telefone = _telefone;         
            Email = _email;

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
    }
}

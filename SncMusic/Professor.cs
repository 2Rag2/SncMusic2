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
        private int id;
        // atributos e propriedades
        //public int Id { get; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Id { get => id; set => id = value; }

        // metodos construtores
        public Professor()
        {

        }
        public Professor(int _id, string _nome, string _cpf, string _email, string _telefone, DateTime _dataCadastro)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Telefone = _telefone;
            Email = _email;
            DataCadastro = _dataCadastro;
        }
        public Professor(string _nome, string _cpf, string _email, string _telefone)
        {
            Nome = _nome;
            Cpf = _cpf;
            Telefone = _telefone;
            Email = _email;
        }
        public Professor(int _id, string _nome, string _telefone)
        {
            Nome = _nome;
            Telefone = _telefone;
            Id = _id;
        }
        public Professor(int _id, string _nome, string _cpf, string _email)
        {
            Nome = _nome;
            Cpf = _cpf;
            Id = _id;
            Email = _email;
        }
        //métodos da classe
        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_professor values (0,@nome,@cpf,@email,@telefone,default)";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = Telefone;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }
        public bool alterar(Professor Professor)
        {
            try //Bloco de tratamento de excessão
            {
                var comm = Banco.Abrir();
                comm.CommandText = "update tb_Professor set nome_Professor = @nome,telefone_Professor = @telefone where id_Professor = @id";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Professor.Nome;
                comm.Parameters.Add("@id", MySqlDbType.VarChar).Value = Professor.id;             
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
                Email = dr.GetString(3);
                Cpf = dr.GetString(2);            
                Telefone = dr.GetString(4);
                DataCadastro = Convert.ToDateTime(dr.GetValue(5));
            }
            Banco.Fechar();

        }
        public List<Professor> ListarTodos()
        {
            List<Professor> listaProfessor = new List<Professor>();
            var comm = Banco.Abrir();
            comm.CommandText = "select * from tb_professor order by 2 ";
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                listaProfessor.Add(new Professor(dr.GetInt32(0),
                  dr.GetString(1),
                 dr.GetString(2), dr.GetString(3),
                 dr.GetString(4),               
                 Convert.ToDateTime(dr.GetValue(5))));

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
        public DataTable ListarPorIdNaoAssociado(string idCurso)
        {
            DataTable dtProfessor = new DataTable();


            var comm = Banco.Abrir();
            comm.CommandText = "select professor_id_professor from tb_professor_curso where curso_id_curso =" + idCurso;
            var dr = comm.ExecuteReader(); //executa a consulta no banco de dados
            List<int> ProfAssoc = new List<int>(); // declara lista de inteiros para armazenar id já associados

            if (dr.HasRows)// verifica se a consulta retonou valores
            {
                while (dr.Read()) //eanquanto exisitirem linhas de resultado
                {
                    ProfAssoc.Add(dr.GetInt32(0)); // associa as linhas à coleção
                }// fim enquanto
                dr.Close(); // fecha o leitor de dados
                dtProfessor.Columns.Add("id_professor", typeof(int));
                dtProfessor.Columns.Add("nome_professor", typeof(string));
                comm.CommandText = "select id_professor, nome_professor from tb_professor";
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    if (!ProfAssoc.Contains(dr.GetInt32(0)))
                        dtProfessor.Rows.Add(dr.GetInt32(0), dr.GetString(1));
                }

            }
            else
            {
                dr.Close();
                comm.CommandText = "select id_professor, nome_professor from tb_professor";
                dtProfessor.Load(comm.ExecuteReader());
            }


            return dtProfessor;
        }
    }
}

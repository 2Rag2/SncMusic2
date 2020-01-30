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
    public class Matricula
    {
        // atributos e propriedades
        public int ID { get; set; }
        public string Situacao { get; set; }
        public string Horario { get; set; }
        public double Valor { get; set; }
        public string Data { get; set; }

        // metodos construtores
        public Matricula()
        {
            Valor = 0.0;

        }
        public Matricula(int id, string situacao, string horario, double valor, string data)
        {
            this.ID = id;
            this.Situacao = situacao;
            this.Horario = horario;
            this.Valor = valor;
            this.Data = data;
        }
        //métodos de classe
        public void Inserir()
        {
            try
            {
                MySqlCommand comm = Banco.Abrir();
                comm.CommandText = "insert into tb_matricula values(0,@id_aluno,@,@valor)";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = ID;
                comm.Parameters.Add("@carga_horaria", MySqlDbType.Int32).Value = Situacao;
                comm.Parameters.Add("@Valor", MySqlDbType.Decimal).Value = Valor;
                comm.ExecuteNonQuery();
                comm.CommandText = "select @@identity";
                ID = Convert.ToInt32(comm.ExecuteScalar());
                Banco.Fechar();

            }
            catch (Exception)
            {

                throw;
            }

        }
        public MySqlDataReader ListarTodos()
        {
            MySqlDataReader dr;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_aluno";
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

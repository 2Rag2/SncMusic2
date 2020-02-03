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
        public int Idmatricula { get; set; }      
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public int IdUsuario { get; set; }
        public string Situacao { get; set; }
        public string Horario { get; set; }
        public string DiasSemana { get; set; }
        public double Valor { get; set; }
        public string Data { get; set; }

        // metodos construtores
        public Matricula()
        {
            

        }
        public Matricula(int _idaluno, int _idUsuario,int _idcurso, string _situacao, string _horario, double _valor, string _data)
        {
           
            IdAluno = _idaluno;
            IdUsuario = _idUsuario;
            IdCurso = _idcurso;
            Situacao = _situacao;
            Horario = _horario;
            Valor = _valor;
            Data = _data;
        }
      
        // Métodos Construtores (new Matricula())

        //métodos de classe
       
     
        public MySqlDataReader ListarTodosAlunos()
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
       

        public MySqlDataReader ListarTodosCursos()
        {
            MySqlDataReader dr;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_curso";
                dr = comm.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
                return dr = null;
            }
        }
        public void ConsultarPorIdCurso(int _id)
        {
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_curso where id_curso = " + _id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    IdCurso = dr.GetInt32(0);
                  
                    Valor = Convert.ToDouble(dr.GetDecimal(3));
                }
            }

            catch (Exception)
            {

            }

        }
        public void Matricular()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_matricula values (0,@idaluno,@idcurso,@situacao,@horario,@diassemana,@valor,default,@idusuario)";
            comm.Parameters.Add("@idaluno", MySqlDbType.Int32).Value = IdAluno;
            comm.Parameters.Add("@idcurso", MySqlDbType.Int32).Value = IdCurso;
            comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = Situacao;
            comm.Parameters.Add("@horario", MySqlDbType.VarChar).Value = Horario;
            comm.Parameters.Add("@diassemana", MySqlDbType.VarChar).Value = DiasSemana ;
            comm.Parameters.Add("@valor", MySqlDbType.Double).Value = Valor;
            comm.Parameters.Add("@idusuario", MySqlDbType.Int32).Value = IdUsuario;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Idmatricula = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }

    }
}

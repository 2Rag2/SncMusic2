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


    }
    public Aluno()
    {

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

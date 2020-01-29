using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SncMusic
{
    public partial class FrmMatricula : Form
    {

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            var dr = matricula.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome_curso";
            cmbCurso.ValueMember = "id_curso";
        }
    }
    public MySqlDataReader ListarTodos()
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
}
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
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void cmbAluno_DropDown(object sender, EventArgs e)
        {
            Matricula curso = new Matricula();
            var dr = curso.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbAluno.DataSource = dt;
            cmbAluno.DisplayMember = "nome_aluno";
            cmbAluno.ValueMember = "id_aluno";
        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {

        }
    }
}

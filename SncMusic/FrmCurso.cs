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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Nome = txtNome.Text;
            curso.CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text);
            curso.Valor = Convert.ToDouble(txtValor.Text);
            curso.Inserir();
            if (curso.Id > 0)
            {
                txtID.Text = curso.Id.ToString();
                MessageBox.Show("Curso cadastro com sucesso!");

            }
            else
            {
                MessageBox.Show("Falha ao cadastro curso!");
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            var dr = curso.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome_curso";
            cmbCurso.ValueMember = "id_curso";
        }

        private void cmbProfessor_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cmbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            Matricula matricula = new Matricula();
            var dr = matricula.ListarTodosAlunos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbAluno.DataSource = dt;
            cmbAluno.DisplayMember = "nome_aluno";
            cmbAluno.ValueMember = "id_aluno";


        }
       

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            var dr = matricula.ListarTodosCursos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome_curso";
            cmbCurso.ValueMember = "id_curso";
            carregado = true;


        }
        bool carregado = false;


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Matricula curso = new Matricula();
            curso.IdAluno = Convert.ToInt32(cmbAluno.SelectedValue.ToString());
            curso.IdCurso = Convert.ToInt32(cmbCurso.SelectedValue.ToString());
            curso.IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue.ToString());
            curso.Situacao = txtsituacao.Text;
            curso.Horario = txtHorario.Text;
            curso.Valor = Convert.ToDouble(txtValor.Text);
            curso.DiasSemana = txtDiadasemana.Text;
            curso.Matricular();          
            
            LimpaControles();
            MessageBox.Show("Curso cadastrado com sucesso!");




        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregado)
            {
                var idcurso = cmbCurso.SelectedValue.ToString();
                if (idcurso != string.Empty)
                {
                    Matricula matricula = new Matricula();
                    matricula.ConsultarPorIdCurso(Convert.ToInt32(idcurso));

                    //txtNome.Text = curso.Nome;
                }

            }
        }
        
        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LimpaControles()
        {
            txtId.Clear();
            txtDiadasemana.Clear();
            txtValor.Clear();
            txtHorario.Clear();
            txtsituacao.Clear();
            txtsituacao.Clear();
            
            txtsituacao.Focus();

        }
        
        private void cmbUsuario_DropDown(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            var dr = usuario.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "nome_usuario";
            cmbUsuario.ValueMember = "id_usuario";
            carregadousuario = true;
        }
        bool carregadousuario = false;
    }
}

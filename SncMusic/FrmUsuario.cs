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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, txtSituacao.Text);

            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtID.Text = usuario.Id.ToString();
                MessageBox.Show("Curso cadastro com sucesso!");

            }
            else
            {
                MessageBox.Show("Falha ao cadastro curso!");
            }

            LimpaControles();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpaControles()
        {
            txtID.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSituacao.Clear();
            txtSenha.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text =="...")
            {
                //alterar o texto do botão para "Buscar"
                btnBuscar.Text = "buscar";
                //tornar o textid readonly true
                txtID.Enabled = true;
                //tornar o textid readonly false
                txtID.ReadOnly = false;
                //colocar o foco (cursor) no txtid e limpe
                txtID.Focus();
                txtID.Clear();
            }
            //senao
            else
            {
                //se txtid for diferente de vazio então consulte o aluno
                if (txtID.Text != string.Empty)
                {
                    Usuario usuario = new Usuario();

                }

            }


        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.alterar(new Usuario(txtEmail.Text, txtNome.Text,txtSenha.Text,txtSituacao.Text)))
            {
                //var comm = Banco.Abrir();
                //comm.CommandText = "update tb_aluno set nome_aluno = '" + txtNome.Text + "'," +
                //    "sexo_aluno = '" + sexo + "', telefone_aluno = '" + mskTelefone.Text +
                //    "'where id_aluno = " + txtId.Text;
                //comm.ExecuteNonQuery();
                //comm.Connection.Close();
                MessageBox.Show("Dados do aluno alterados com Sucesso!");
                LimpaControles();

            }
            else
            {
                MessageBox.Show("erro");
            }
        }
    }
}

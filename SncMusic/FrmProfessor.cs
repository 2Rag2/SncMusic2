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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Professor professor = new Professor( txtNome.Text , mskCPF.Text, txtEmail.Text, mskTelefone.Text);
            professor.Inserir();

            MessageBox.Show("professor Gravado com Sucesso!");
            LimpaControles();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se text do botâo for igual a "..."
            if (btnBuscar.Text == "...")
            {
                //alterar o texto do botão para "Buscar"
                btnBuscar.Text = "buscar";
                //tornar o textid readonly true
                txtId.Enabled = true;
                //tornar o textid readonly false
                txtId.ReadOnly = false;
                //colocar o foco (cursor) no txtid e limpe
                txtId.Focus();
                txtId.Clear();
            }
            //senao
            else
            {
                //se txtid for diferente de vazio então consulte o professor
                if (txtId.Text != string.Empty)
                {
                    Professor professor = new Professor();
                    professor.ConsultarPorId(Convert.ToInt32(txtId.Text));
                    txtEmail.Text = professor.Email;
                    mskCPF.Text = professor.cpf;
                    mskTelefone.Text = professor.Telefone;
                    txtNome.Text = professor.Nome;
                   
                    //altee o texto do botão para"..."
                    btnBuscar.Text = "...";
                    //tornar o txtid enable flase
                    txtId.Enabled = false;
                    //tornar o textid readonly true
                    txtId.ReadOnly = true;
                }

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
          
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Professor professor = new Professor();
            if (professor.alterar(new Professor(Convert.ToInt32(txtId.Text), txtNome.Text, mskTelefone.Text)))
            {
                //var comm = Banco.Abrir();
                //comm.CommandText = "update tb_professor set nome_professor = '" + txtNome.Text + "'," +
                //    "sexo_professor = '" + sexo + "', telefone_professor = '" + mskTelefone.Text +
                //    "'where id_professor = " + txtId.Text;
                //comm.ExecuteNonQuery();
                //comm.Connection.Close();
                MessageBox.Show("Dados do professor alterados com Sucesso!");
                LimpaControles();

            }
            else
            {
                MessageBox.Show("erro");
            }


        }

        private void Frmprofessor_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void LimpaControles()
        {
            txtId.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();       
            txtId.Focus();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }   
    
}

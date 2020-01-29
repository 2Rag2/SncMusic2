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
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbMasculino.Checked)sexo = "M";
             else sexo = "F"; // resolve o sexo
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Aluno aluno = new Aluno(txtNome.Text, mskCPF.Text, sexo, txtEmail.Text,mskTelefone.Text);
            aluno.Inserir();

            MessageBox.Show("Aluno Gravado com Sucesso!");
            LimpaControles();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se text do botâo for igual a "..."
            if(btnBuscar.Text =="...")
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
                //se txtid for diferente de vazio então consulte o aluno
                if (txtId.Text != string.Empty)
                {
                    Aluno aluno = new Aluno();
                    aluno.ConsultarPorId(Convert.ToInt32(txtId.Text));
                    txtEmail.Text = aluno.Email;
                    mskCPF.Text = aluno.cpf;
                    mskTelefone.Text = aluno.Telefone;
                    txtNome.Text = aluno.Nome;
                    if (aluno.sexo == "M")
                        rdbMasculino.Checked = true;
                    else
                        rdbFeminino.Checked = true;

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
            string sexo;
            if (rdbMasculino.Checked) sexo = "M";
            else sexo = "F"; // resolve o sexo
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Aluno aluno = new Aluno();
            if (aluno.alterar(new Aluno(Convert.ToInt32(txtId.Text), txtNome.Text, sexo, mskTelefone.Text)))
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

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja realmente Excluir o aluno ",
                "Excluir Aluno ...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && txtId.Text != string.Empty)
            {
                var comm = Banco.Abrir();
                comm.CommandText = "delete from tb_aluno where id_aluno =" + txtId.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Aluno excluido com Sucesso!");
                LimpaControles();
            }


        }
        private void LimpaControles()
        {
            txtId.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            txtId.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Aluno aluno = new Aluno();
            var lista = aluno.ListarTodos();
            foreach(var item in lista)
            {
                listBox1.Items.Add(item.Nome);
            }
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)

                btnAlterar.Enabled = true;

            else

                btnAlterar.Enabled = false;
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
                //se txtid for diferente de vazio então consulte o aluno
                if (txtId.Text != string.Empty)
                {
                    //consultar o aluno
                    var comm = Banco.Abrir();
                    comm.CommandText = "select* from tb_professor where id_professor = " + txtId.Text;
                    var dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        txtNome.Text = dr.GetString(1);
                        txtEmail.Text = dr.GetString(4);
                        mskCPF.Text = dr.GetString(2);
                        mskTelefone.Text = dr.GetString(5);
                        if (dr.GetString(3) == "M")
                            rdbMasculino.Checked = true;
                        else
                            rdbFeminino.Checked = true;

                    }
                    //altee o texto do botão para"..."
                    btnBuscar.Text = "...";
                    //tornar o txtid enable flase
                    txtId.Enabled = false;
                    //tornar o textid readonly true
                    txtId.ReadOnly = true;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbMasculino.Checked) sexo = "M";
            else sexo = "F"; // resolve o sexo
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            var comm = Banco.Abrir();
            comm.CommandText = "update tb_professor set nome_professor = '" + txtNome.Text + "'," +
                "sexo_professor = '" + sexo + "', telefone_professor = '" + mskTelefone.Text +
                "'where id_professor = " + txtId.Text;
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            MessageBox.Show("Dados do aluno alterados com Sucesso!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbMasculino.Checked) sexo = "M";
            else sexo = "F"; // resolve o sexo
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            var comm = Banco.Abrir();
            comm.CommandText = "INSERT INTO tb_professor VALUES (0,'" +
                txtNome.Text + "','" +
                mskCPF.Text + "','" +
                sexo + "','" +
                txtEmail.Text + "','" +
                mskTelefone.Text + "',default);";
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            txtId.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();
            MessageBox.Show("Professor Gravado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja realmente Excluir o aluno ",
                "Excluir Professor ...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg == DialogResult.Yes  && txtId.Text != string.Empty)
            {
                var comm = Banco.Abrir();
                comm.CommandText = "delete from tb_professor where id_professor =" + txtId.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Professor excluido com Sucesso!");
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
    }   
    
}

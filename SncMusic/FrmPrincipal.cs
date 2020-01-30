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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.MdiParent = this;
            frmAluno.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfessor frmprofessor = new FrmProfessor();
            frmprofessor.MdiParent = this;
            frmprofessor.Show();

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

         private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.MdiParent = this;
            frmCurso.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.MdiParent = this;
            frmMatricula.Show();
        }
    }
}

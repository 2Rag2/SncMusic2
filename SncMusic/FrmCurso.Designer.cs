namespace SncMusic
{
    partial class FrmCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(216, 220);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 28);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(324, 220);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(432, 220);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carga Horária";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor R$";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(216, 98);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 22);
            this.txtNome.TabIndex = 8;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(216, 132);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(132, 22);
            this.txtCargaHoraria.TabIndex = 9;
            this.txtCargaHoraria.TextChanged += new System.EventHandler(this.txtCargaHoraria_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(216, 165);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProfessor);
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Controls.Add(this.btnAssociar);
            this.groupBox1.Location = new System.Drawing.Point(81, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(647, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associar Professor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Professor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Curso";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(291, 76);
            this.cmbProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(239, 24);
            this.cmbProfessor.TabIndex = 2;
            this.cmbProfessor.DropDown += new System.EventHandler(this.cmbProfessor_DropDown_1);
            this.cmbProfessor.SelectedIndexChanged += new System.EventHandler(this.cmbProfessor_SelectedIndexChanged);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(28, 76);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(253, 24);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCurso_DrawItem);
            this.cmbCurso.DropDown += new System.EventHandler(this.cmbCurso_DropDown_1);
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(539, 74);
            this.btnAssociar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(100, 28);
            this.btnAssociar.TabIndex = 0;
            this.btnAssociar.Text = "Associar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(219, 69);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(97, 22);
            this.txtId.TabIndex = 54;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInserir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCurso";
            this.Text = "Cadastro de Cursos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.TextBox txtId;
    }
}
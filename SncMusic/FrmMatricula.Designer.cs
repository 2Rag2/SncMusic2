namespace SncMusic
{
    partial class FrmMatricula
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
            this.txtsituacao = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDiadasemana = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsituacao
            // 
            this.txtsituacao.Location = new System.Drawing.Point(119, 128);
            this.txtsituacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtsituacao.Name = "txtsituacao";
            this.txtsituacao.Size = new System.Drawing.Size(181, 22);
            this.txtsituacao.TabIndex = 8;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(119, 158);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(80, 22);
            this.txtHorario.TabIndex = 9;
            // 
            // txtDiadasemana
            // 
            this.txtDiadasemana.Location = new System.Drawing.Point(119, 185);
            this.txtDiadasemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiadasemana.Name = "txtDiadasemana";
            this.txtDiadasemana.Size = new System.Drawing.Size(80, 22);
            this.txtDiadasemana.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(119, 219);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 22);
            this.txtValor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Situação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dia da semana";
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.Location = new System.Drawing.Point(50, 158);
            this.Horario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(55, 17);
            this.Horario.TabIndex = 17;
            this.Horario.Text = "Harario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor curso";
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(206, 286);
            this.cmbAluno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(160, 24);
            this.cmbAluno.TabIndex = 0;
            this.cmbAluno.DropDown += new System.EventHandler(this.cmbAluno_DropDown);
            this.cmbAluno.SelectedIndexChanged += new System.EventHandler(this.cmbAluno_SelectedIndexChanged);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(13, 286);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(160, 24);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.DropDown += new System.EventHandler(this.cmbCurso_DropDown);
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Aluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Curso";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(99, 332);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 28);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 98);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(97, 22);
            this.txtId.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(395, 286);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(160, 24);
            this.cmbUsuario.TabIndex = 57;
            this.cmbUsuario.DropDown += new System.EventHandler(this.cmbUsuario_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Usuario";
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDiadasemana);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtsituacao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMatricula";
            this.Text = "FrmMatricula";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsituacao;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDiadasemana;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label2;
    }


   

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
}
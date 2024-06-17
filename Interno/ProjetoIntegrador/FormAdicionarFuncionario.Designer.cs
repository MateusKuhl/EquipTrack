namespace ProjetoIntegrador
{
    partial class FormAdicionarFuncionario
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
            labelAdicionarFuncionario = new Label();
            label2 = new Label();
            txtNomeFuncionario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmailFuncionario = new TextBox();
            radioFuncionario = new RadioButton();
            radioProfessor = new RadioButton();
            btnCadastrarFuncionario = new Button();
            btnEditarFuncionario = new Button();
            btnCancelarFuncionario = new Button();
            txtIdFuncionario = new TextBox();
            SuspendLayout();
            // 
            // labelAdicionarFuncionario
            // 
            labelAdicionarFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdicionarFuncionario.Location = new Point(93, 20);
            labelAdicionarFuncionario.Name = "labelAdicionarFuncionario";
            labelAdicionarFuncionario.Size = new Size(247, 21);
            labelAdicionarFuncionario.TabIndex = 0;
            labelAdicionarFuncionario.Text = "Cadastrar um novo funcionário";
            labelAdicionarFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome :";
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(121, 83);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(247, 23);
            txtNomeFuncionario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 126);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "E-Mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 166);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Cargo :";
            // 
            // txtEmailFuncionario
            // 
            txtEmailFuncionario.Location = new Point(121, 123);
            txtEmailFuncionario.Name = "txtEmailFuncionario";
            txtEmailFuncionario.Size = new Size(247, 23);
            txtEmailFuncionario.TabIndex = 5;
            // 
            // radioFuncionario
            // 
            radioFuncionario.AutoSize = true;
            radioFuncionario.Location = new Point(121, 166);
            radioFuncionario.Name = "radioFuncionario";
            radioFuncionario.Size = new Size(88, 19);
            radioFuncionario.TabIndex = 6;
            radioFuncionario.TabStop = true;
            radioFuncionario.Text = "Funcionário";
            radioFuncionario.UseVisualStyleBackColor = true;
            // 
            // radioProfessor
            // 
            radioProfessor.AutoSize = true;
            radioProfessor.Location = new Point(121, 191);
            radioProfessor.Name = "radioProfessor";
            radioProfessor.Size = new Size(74, 19);
            radioProfessor.TabIndex = 7;
            radioProfessor.TabStop = true;
            radioProfessor.Text = "Professor";
            radioProfessor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Location = new Point(51, 259);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(106, 36);
            btnCadastrarFuncionario.TabIndex = 8;
            btnCadastrarFuncionario.Text = "Cadastrar";
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.Location = new Point(163, 259);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(106, 36);
            btnEditarFuncionario.TabIndex = 9;
            btnEditarFuncionario.Text = "Editar";
            btnEditarFuncionario.UseVisualStyleBackColor = true;
            btnEditarFuncionario.Click += btnEditarFuncionario_Click;
            // 
            // btnCancelarFuncionario
            // 
            btnCancelarFuncionario.Location = new Point(275, 259);
            btnCancelarFuncionario.Name = "btnCancelarFuncionario";
            btnCancelarFuncionario.Size = new Size(106, 36);
            btnCancelarFuncionario.TabIndex = 10;
            btnCancelarFuncionario.Text = "Cancelar";
            btnCancelarFuncionario.UseVisualStyleBackColor = true;
            btnCancelarFuncionario.Click += btnCancelarFuncionario_Click;
            // 
            // txtIdFuncionario
            // 
            txtIdFuncionario.Location = new Point(37, 61);
            txtIdFuncionario.Name = "txtIdFuncionario";
            txtIdFuncionario.Size = new Size(17, 23);
            txtIdFuncionario.TabIndex = 11;
            txtIdFuncionario.Visible = false;
            // 
            // FormAdicionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 321);
            Controls.Add(txtIdFuncionario);
            Controls.Add(btnCancelarFuncionario);
            Controls.Add(btnEditarFuncionario);
            Controls.Add(btnCadastrarFuncionario);
            Controls.Add(radioProfessor);
            Controls.Add(radioFuncionario);
            Controls.Add(txtEmailFuncionario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNomeFuncionario);
            Controls.Add(label2);
            Controls.Add(labelAdicionarFuncionario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdicionarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdicionarFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        public Button btnCadastrarFuncionario;
        public Button btnEditarFuncionario;
        public Button btnCancelarFuncionario;
        public TextBox txtNomeFuncionario;
        public TextBox txtEmailFuncionario;
        public RadioButton radioFuncionario;
        public RadioButton radioProfessor;
        public TextBox txtIdFuncionario;
        public Label labelAdicionarFuncionario;
    }
}
namespace ProjetoIntegrador
{
    partial class FormCadastrarLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSenha = new TextBox();
            txtRA = new MaskedTextBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 49);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "RA :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 113);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 182);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirmar senha :";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(45, 131);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(211, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtRA
            // 
            txtRA.Location = new Point(128, 67);
            txtRA.Mask = "0000/00-0";
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(62, 23);
            txtRA.TabIndex = 4;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(45, 200);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(211, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(101, 248);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(120, 42);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrarLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 327);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtRA);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCadastrarLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSenha;
        private MaskedTextBox txtRA;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
    }
}
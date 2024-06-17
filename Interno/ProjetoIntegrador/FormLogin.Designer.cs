namespace ProjetoIntegrador
{
    partial class FormLogin
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
            btnLogin = new Button();
            checkBoxMostrarSenha = new CheckBox();
            btnCadastrarLogin = new Button();
            txtRa = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 34);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Fazer login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 92);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "RA :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha :";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(43, 202);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(242, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(97, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBoxMostrarSenha
            // 
            checkBoxMostrarSenha.AutoSize = true;
            checkBoxMostrarSenha.Location = new Point(121, 231);
            checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            checkBoxMostrarSenha.Size = new Size(101, 19);
            checkBoxMostrarSenha.TabIndex = 6;
            checkBoxMostrarSenha.Text = "Mostrar senha";
            checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            checkBoxMostrarSenha.CheckedChanged += checkBoxMostrarSenha_CheckedChanged;
            // 
            // btnCadastrarLogin
            // 
            btnCadastrarLogin.Location = new Point(97, 340);
            btnCadastrarLogin.Name = "btnCadastrarLogin";
            btnCadastrarLogin.Size = new Size(151, 46);
            btnCadastrarLogin.TabIndex = 7;
            btnCadastrarLogin.Text = "Cadastre-se";
            btnCadastrarLogin.UseVisualStyleBackColor = true;
            btnCadastrarLogin.Click += btnCadastrarLogin_Click;
            // 
            // txtRa
            // 
            txtRa.Location = new Point(137, 123);
            txtRa.Mask = "0000/00-0";
            txtRa.Name = "txtRa";
            txtRa.Size = new Size(63, 23);
            txtRa.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 415);
            Controls.Add(txtRa);
            Controls.Add(btnCadastrarLogin);
            Controls.Add(checkBoxMostrarSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSenha;
        private Button btnLogin;
        private CheckBox checkBoxMostrarSenha;
        private Button btnCadastrarLogin;
        private MaskedTextBox txtRa;
    }
}
namespace ProjetoIntegrador
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRelatorios = new Button();
            btnAgendamentos = new Button();
            btnFuncionarios = new Button();
            btnEstoque = new Button();
            panel2 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnRelatorios);
            panel1.Controls.Add(btnAgendamentos);
            panel1.Controls.Add(btnFuncionarios);
            panel1.Controls.Add(btnEstoque);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 591);
            panel1.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Dock = DockStyle.Top;
            btnRelatorios.Location = new Point(0, 377);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(200, 86);
            btnRelatorios.TabIndex = 4;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnAgendamentos
            // 
            btnAgendamentos.Dock = DockStyle.Top;
            btnAgendamentos.Location = new Point(0, 291);
            btnAgendamentos.Name = "btnAgendamentos";
            btnAgendamentos.Size = new Size(200, 86);
            btnAgendamentos.TabIndex = 3;
            btnAgendamentos.Text = "Agendamentos";
            btnAgendamentos.UseVisualStyleBackColor = true;
            btnAgendamentos.Click += btnAgendamentos_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Dock = DockStyle.Top;
            btnFuncionarios.Location = new Point(0, 205);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(200, 86);
            btnFuncionarios.TabIndex = 2;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Dock = DockStyle.Top;
            btnEstoque.Location = new Point(0, 119);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(200, 86);
            btnEstoque.TabIndex = 1;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 119);
            panel2.TabIndex = 0;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Top;
            pnlFormLoader.Location = new Point(200, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(707, 591);
            pnlFormLoader.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(907, 591);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlFormLoader;
        private Button btnEstoque;
        private Button btnRelatorios;
        private Button btnAgendamentos;
        private Button btnFuncionarios;
    }
}

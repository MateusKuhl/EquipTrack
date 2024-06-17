namespace ProjetoIntegrador
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            label1 = new Label();
            dgvFuncionarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Excluir = new DataGridViewImageColumn();
            btnCadastrarFuncionarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 19);
            label1.Name = "label1";
            label1.Size = new Size(305, 32);
            label1.TabIndex = 0;
            label1.Text = "Funcionários cadastrados";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.BackgroundColor = Color.White;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Editar, Excluir });
            dgvFuncionarios.EnableHeadersVisualStyles = false;
            dgvFuncionarios.Location = new Point(12, 68);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.Size = new Size(683, 398);
            dgvFuncionarios.TabIndex = 1;
            dgvFuncionarios.CellContentClick += dgvFuncionarios_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 65;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Cargo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 64;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "E-Mail";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Editar.HeaderText = "";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 5;
            // 
            // Excluir
            // 
            Excluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Excluir.HeaderText = "";
            Excluir.Image = (Image)resources.GetObject("Excluir.Image");
            Excluir.Name = "Excluir";
            Excluir.ReadOnly = true;
            Excluir.Width = 5;
            // 
            // btnCadastrarFuncionarios
            // 
            btnCadastrarFuncionarios.Location = new Point(12, 488);
            btnCadastrarFuncionarios.Name = "btnCadastrarFuncionarios";
            btnCadastrarFuncionarios.Size = new Size(139, 47);
            btnCadastrarFuncionarios.TabIndex = 2;
            btnCadastrarFuncionarios.Text = "Cadastrar";
            btnCadastrarFuncionarios.UseVisualStyleBackColor = true;
            btnCadastrarFuncionarios.Click += btnCadastrarFuncionarios_Click;
            // 
            // FormFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 591);
            Controls.Add(btnCadastrarFuncionarios);
            Controls.Add(dgvFuncionarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFuncionarios";
            Text = "FormFuncionarios";
            Load += FormFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvFuncionarios;
        private Button btnCadastrarFuncionarios;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Excluir;
    }
}
namespace ProjetoIntegrador
{
    partial class FormAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendamentos));
            label1 = new Label();
            dgvAgendamentos = new DataGridView();
            btnAdicionarAgendamento = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Excluir = new DataGridViewImageColumn();
            Baixa = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 19);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "Agendamentos";
            // 
            // dgvAgendamentos
            // 
            dgvAgendamentos.AllowUserToAddRows = false;
            dgvAgendamentos.BackgroundColor = Color.White;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendamentos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column8, Column9, Editar, Excluir, Baixa });
            dgvAgendamentos.EnableHeadersVisualStyles = false;
            dgvAgendamentos.Location = new Point(12, 68);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.Size = new Size(683, 398);
            dgvAgendamentos.TabIndex = 1;
            dgvAgendamentos.CellContentClick += dgvAgendamentos_CellContentClick;
            // 
            // btnAdicionarAgendamento
            // 
            btnAdicionarAgendamento.Location = new Point(12, 488);
            btnAdicionarAgendamento.Name = "btnAdicionarAgendamento";
            btnAdicionarAgendamento.Size = new Size(139, 47);
            btnAdicionarAgendamento.TabIndex = 2;
            btnAdicionarAgendamento.Text = "Adicionar";
            btnAdicionarAgendamento.UseVisualStyleBackColor = true;
            btnAdicionarAgendamento.Click += btnAdicionarAgendamento_Click;
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
            Column2.HeaderText = "Funcionário";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 95;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Item";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Qtd";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 52;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Data";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 56;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Horário";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 72;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Bloco";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 62;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Sala";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 53;
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
            // Baixa
            // 
            Baixa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Baixa.HeaderText = "";
            Baixa.Image = (Image)resources.GetObject("Baixa.Image");
            Baixa.Name = "Baixa";
            Baixa.ReadOnly = true;
            Baixa.Width = 5;
            // 
            // FormAgendamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 591);
            Controls.Add(btnAdicionarAgendamento);
            Controls.Add(dgvAgendamentos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgendamentos";
            Text = "FormAgendamentos";
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAgendamentos;
        private Button btnAdicionarAgendamento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Excluir;
        private DataGridViewImageColumn Baixa;
    }
}
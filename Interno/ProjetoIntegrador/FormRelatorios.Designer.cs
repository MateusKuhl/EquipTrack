namespace ProjetoIntegrador
{
    partial class FormRelatorios
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
            dgvAgendamentos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvFuncionariosUtilizaram = new DataGridView();
            dgvItensUtilizados = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            Column10 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionariosUtilizaram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensUtilizados).BeginInit();
            SuspendLayout();
            // 
            // dgvAgendamentos
            // 
            dgvAgendamentos.AllowUserToAddRows = false;
            dgvAgendamentos.BackgroundColor = Color.White;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendamentos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvAgendamentos.EnableHeadersVisualStyles = false;
            dgvAgendamentos.Location = new Point(29, 88);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.Size = new Size(648, 206);
            dgvAgendamentos.TabIndex = 0;
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
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Bloco";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 62;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Sala";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 19);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 1;
            label1.Text = "Relatórios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 2;
            label2.Text = "Agendamentos finalizados";
            // 
            // dgvFuncionariosUtilizaram
            // 
            dgvFuncionariosUtilizaram.AllowUserToAddRows = false;
            dgvFuncionariosUtilizaram.BackgroundColor = Color.White;
            dgvFuncionariosUtilizaram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionariosUtilizaram.Columns.AddRange(new DataGridViewColumn[] { Column10, Column12 });
            dgvFuncionariosUtilizaram.EnableHeadersVisualStyles = false;
            dgvFuncionariosUtilizaram.Location = new Point(29, 376);
            dgvFuncionariosUtilizaram.Name = "dgvFuncionariosUtilizaram";
            dgvFuncionariosUtilizaram.ReadOnly = true;
            dgvFuncionariosUtilizaram.Size = new Size(302, 175);
            dgvFuncionariosUtilizaram.TabIndex = 3;
            // 
            // dgvItensUtilizados
            // 
            dgvItensUtilizados.AllowUserToAddRows = false;
            dgvItensUtilizados.BackgroundColor = Color.White;
            dgvItensUtilizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensUtilizados.Columns.AddRange(new DataGridViewColumn[] { Column13, Column14 });
            dgvItensUtilizados.EnableHeadersVisualStyles = false;
            dgvItensUtilizados.Location = new Point(382, 376);
            dgvItensUtilizados.Name = "dgvItensUtilizados";
            dgvItensUtilizados.ReadOnly = true;
            dgvItensUtilizados.Size = new Size(295, 175);
            dgvItensUtilizados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 337);
            label3.Name = "label3";
            label3.Size = new Size(302, 25);
            label3.TabIndex = 5;
            label3.Text = "Funcionários que mais agendaram";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(382, 337);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 6;
            label4.Text = "Itens mais agendados";
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Nome";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.HeaderText = "Total";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 57;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column13.HeaderText = "Nome";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column14.HeaderText = "Total";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 57;
            // 
            // FormRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 591);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvItensUtilizados);
            Controls.Add(dgvFuncionariosUtilizaram);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAgendamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRelatorios";
            Text = "FormRelatorios";
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionariosUtilizaram).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensUtilizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAgendamentos;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridView dgvFuncionariosUtilizaram;
        private DataGridView dgvItensUtilizados;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}
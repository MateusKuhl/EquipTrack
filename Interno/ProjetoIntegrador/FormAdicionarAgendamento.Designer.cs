namespace ProjetoIntegrador
{
    partial class FormAdicionarAgendamento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtIdAgendamento = new TextBox();
            txtNomeFuncionario = new TextBox();
            txtIdFuncionario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtProcurarFuncionario = new TextBox();
            label1 = new Label();
            dgvFuncionarios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnEditarAgendamento = new Button();
            btnAgendar = new Button();
            txtSala = new TextBox();
            txtBloco = new TextBox();
            label14 = new Label();
            label13 = new Label();
            dateDataAgendamento = new DateTimePicker();
            txtHorario2 = new MaskedTextBox();
            txtHorario1 = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            numQuantidadeItem = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            txtNomeItem = new TextBox();
            txtIdItem = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            txtProcurarItem = new TextBox();
            label2 = new Label();
            dgvItens = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtIdAgendamento);
            panel1.Controls.Add(txtNomeFuncionario);
            panel1.Controls.Add(txtIdFuncionario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtProcurarFuncionario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvFuncionarios);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 511);
            panel1.TabIndex = 0;
            // 
            // txtIdAgendamento
            // 
            txtIdAgendamento.Location = new Point(27, 470);
            txtIdAgendamento.Name = "txtIdAgendamento";
            txtIdAgendamento.Size = new Size(24, 23);
            txtIdAgendamento.TabIndex = 10;
            txtIdAgendamento.Visible = false;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Enabled = false;
            txtNomeFuncionario.Location = new Point(27, 372);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(204, 23);
            txtNomeFuncionario.TabIndex = 9;
            // 
            // txtIdFuncionario
            // 
            txtIdFuncionario.Enabled = false;
            txtIdFuncionario.Location = new Point(27, 315);
            txtIdFuncionario.Name = "txtIdFuncionario";
            txtIdFuncionario.Size = new Size(204, 23);
            txtIdFuncionario.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 350);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 7;
            label6.Text = "Nome do funcionário :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 293);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 6;
            label5.Text = "Id do funcionário :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 221);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Procurar :";
            // 
            // txtProcurarFuncionario
            // 
            txtProcurarFuncionario.Location = new Point(113, 218);
            txtProcurarFuncionario.Name = "txtProcurarFuncionario";
            txtProcurarFuncionario.Size = new Size(131, 23);
            txtProcurarFuncionario.TabIndex = 4;
            txtProcurarFuncionario.TextChanged += txtProcurarFuncionario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 253);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 3;
            label1.Text = "Dados do Funcionário";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.BackgroundColor = Color.White;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvFuncionarios.Dock = DockStyle.Top;
            dgvFuncionarios.EnableHeadersVisualStyles = false;
            dgvFuncionarios.Location = new Point(0, 0);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.RowHeadersVisible = false;
            dgvFuncionarios.Size = new Size(258, 212);
            dgvFuncionarios.TabIndex = 2;
            dgvFuncionarios.CellClick += dgvFuncionarios_CellClick;
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
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditarAgendamento);
            panel2.Controls.Add(btnAgendar);
            panel2.Controls.Add(txtSala);
            panel2.Controls.Add(txtBloco);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(dateDataAgendamento);
            panel2.Controls.Add(txtHorario2);
            panel2.Controls.Add(txtHorario1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(numQuantidadeItem);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtNomeItem);
            panel2.Controls.Add(txtIdItem);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtProcurarItem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvItens);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(264, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 511);
            panel2.TabIndex = 1;
            // 
            // btnEditarAgendamento
            // 
            btnEditarAgendamento.Location = new Point(367, 440);
            btnEditarAgendamento.Name = "btnEditarAgendamento";
            btnEditarAgendamento.Size = new Size(127, 53);
            btnEditarAgendamento.TabIndex = 25;
            btnEditarAgendamento.Text = "Editar";
            btnEditarAgendamento.UseVisualStyleBackColor = true;
            btnEditarAgendamento.Click += btnEditarAgendamento_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(232, 440);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(127, 53);
            btnAgendar.TabIndex = 24;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(403, 372);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(91, 23);
            txtSala.TabIndex = 23;
            // 
            // txtBloco
            // 
            txtBloco.Location = new Point(354, 372);
            txtBloco.Name = "txtBloco";
            txtBloco.Size = new Size(43, 23);
            txtBloco.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(403, 350);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 21;
            label14.Text = "Sala :";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(354, 350);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 20;
            label13.Text = "Bloco :";
            // 
            // dateDataAgendamento
            // 
            dateDataAgendamento.CustomFormat = "dd/MM/yyyy";
            dateDataAgendamento.Format = DateTimePickerFormat.Custom;
            dateDataAgendamento.Location = new Point(232, 315);
            dateDataAgendamento.Name = "dateDataAgendamento";
            dateDataAgendamento.Size = new Size(262, 23);
            dateDataAgendamento.TabIndex = 19;
            // 
            // txtHorario2
            // 
            txtHorario2.Location = new Point(299, 372);
            txtHorario2.Mask = "00:00";
            txtHorario2.Name = "txtHorario2";
            txtHorario2.Size = new Size(37, 23);
            txtHorario2.TabIndex = 18;
            txtHorario2.TextAlign = HorizontalAlignment.Center;
            txtHorario2.ValidatingType = typeof(DateTime);
            // 
            // txtHorario1
            // 
            txtHorario1.Location = new Point(232, 372);
            txtHorario1.Mask = "00:00";
            txtHorario1.Name = "txtHorario1";
            txtHorario1.Size = new Size(37, 23);
            txtHorario1.TabIndex = 17;
            txtHorario1.TextAlign = HorizontalAlignment.Center;
            txtHorario1.ValidatingType = typeof(DateTime);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(275, 375);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 16;
            label12.Text = "às";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(232, 350);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 13;
            label11.Text = "Horário :";
            // 
            // numQuantidadeItem
            // 
            numQuantidadeItem.Location = new Point(20, 429);
            numQuantidadeItem.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantidadeItem.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidadeItem.Name = "numQuantidadeItem";
            numQuantidadeItem.Size = new Size(175, 23);
            numQuantidadeItem.TabIndex = 12;
            numQuantidadeItem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidadeItem.ValueChanged += numQuantidadeItem_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 407);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 11;
            label10.Text = "Quantidade :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 293);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 10;
            label9.Text = "Data :";
            // 
            // txtNomeItem
            // 
            txtNomeItem.Enabled = false;
            txtNomeItem.Location = new Point(20, 372);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(175, 23);
            txtNomeItem.TabIndex = 8;
            // 
            // txtIdItem
            // 
            txtIdItem.Enabled = false;
            txtIdItem.Location = new Point(20, 315);
            txtIdItem.Name = "txtIdItem";
            txtIdItem.Size = new Size(175, 23);
            txtIdItem.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 350);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 6;
            label8.Text = "Nome do item :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 293);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 5;
            label7.Text = "Id do item :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 221);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Procurar :";
            // 
            // txtProcurarItem
            // 
            txtProcurarItem.Location = new Point(338, 218);
            txtProcurarItem.Name = "txtProcurarItem";
            txtProcurarItem.Size = new Size(142, 23);
            txtProcurarItem.TabIndex = 3;
            txtProcurarItem.TextChanged += txtProcurarItem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 253);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 2;
            label2.Text = "Dados do Item";
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.BackgroundColor = Color.White;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { Column5, dataGridViewTextBoxColumn1, Column3, Column4 });
            dgvItens.Dock = DockStyle.Top;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.Location = new Point(0, 0);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItens.RowHeadersVisible = false;
            dgvItens.Size = new Size(506, 212);
            dgvItens.TabIndex = 1;
            dgvItens.CellClick += dgvItens_CellClick;
            dgvItens.CellContentClick += dgvItens_CellContentClick;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Id";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Situaçao";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 77;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Quantidade";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 94;
            // 
            // FormAdicionarAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAdicionarAgendamento";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdicionarAgendamento";
            Load += FormAdicionarAgendamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private TextBox txtProcurarFuncionario;
        private TextBox txtProcurarItem;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label13;
        private Label label14;
        public Button btnEditarAgendamento;
        public Button btnAgendar;
        public TextBox txtNomeFuncionario;
        public TextBox txtIdFuncionario;
        public TextBox txtNomeItem;
        public TextBox txtIdItem;
        public NumericUpDown numQuantidadeItem;
        public MaskedTextBox txtHorario1;
        public MaskedTextBox txtHorario2;
        public DateTimePicker dateDataAgendamento;
        public TextBox txtSala;
        public TextBox txtBloco;
        public DataGridView dgvFuncionarios;
        public DataGridView dgvItens;
        public TextBox txtIdAgendamento;
    }
}
namespace ProjetoIntegrador
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            dgvItens = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Excluir = new DataGridViewImageColumn();
            btnAdicionarItem = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.BackgroundColor = Color.White;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column3, Column4, Editar, Excluir });
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.Location = new Point(12, 68);
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
            dgvItens.Size = new Size(683, 398);
            dgvItens.TabIndex = 0;
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
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(12, 488);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(139, 47);
            btnAdicionarItem.TabIndex = 1;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 19);
            label1.Name = "label1";
            label1.Size = new Size(211, 33);
            label1.TabIndex = 2;
            label1.Text = "Itens em estoque";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 591);
            Controls.Add(label1);
            Controls.Add(btnAdicionarItem);
            Controls.Add(dgvItens);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEstoque";
            Text = "FormEstoque";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItens;
        private Button btnAdicionarItem;
        private Label label1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Excluir;
    }
}
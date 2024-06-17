namespace ProjetoIntegrador
{
    partial class FormAdicionarItem
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
            labelAdicionarItem = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            numQuantidadeItem = new NumericUpDown();
            txtNomeItem = new TextBox();
            radioFuncional = new RadioButton();
            radioConserto = new RadioButton();
            radioNaoFuncional = new RadioButton();
            btnCadastrarItem = new Button();
            btnCancelarItem = new Button();
            btnEditarItem = new Button();
            txtIdItem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).BeginInit();
            SuspendLayout();
            // 
            // labelAdicionarItem
            // 
            labelAdicionarItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdicionarItem.Location = new Point(120, 20);
            labelAdicionarItem.Name = "labelAdicionarItem";
            labelAdicionarItem.Size = new Size(193, 21);
            labelAdicionarItem.TabIndex = 0;
            labelAdicionarItem.Text = "Cadastrar um novo item";
            labelAdicionarItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 134);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 164);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Situação :";
            // 
            // numQuantidadeItem
            // 
            numQuantidadeItem.Location = new Point(125, 132);
            numQuantidadeItem.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numQuantidadeItem.Name = "numQuantidadeItem";
            numQuantidadeItem.Size = new Size(247, 23);
            numQuantidadeItem.TabIndex = 5;
            numQuantidadeItem.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(125, 92);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.Size = new Size(247, 23);
            txtNomeItem.TabIndex = 6;
            // 
            // radioFuncional
            // 
            radioFuncional.AutoSize = true;
            radioFuncional.Location = new Point(125, 164);
            radioFuncional.Name = "radioFuncional";
            radioFuncional.Size = new Size(77, 19);
            radioFuncional.TabIndex = 8;
            radioFuncional.TabStop = true;
            radioFuncional.Text = "Funcional";
            radioFuncional.UseVisualStyleBackColor = true;
            // 
            // radioConserto
            // 
            radioConserto.AutoSize = true;
            radioConserto.Location = new Point(125, 189);
            radioConserto.Name = "radioConserto";
            radioConserto.Size = new Size(91, 19);
            radioConserto.TabIndex = 9;
            radioConserto.TabStop = true;
            radioConserto.Text = "Em conserto";
            radioConserto.UseVisualStyleBackColor = true;
            // 
            // radioNaoFuncional
            // 
            radioNaoFuncional.AutoSize = true;
            radioNaoFuncional.Location = new Point(125, 214);
            radioNaoFuncional.Name = "radioNaoFuncional";
            radioNaoFuncional.Size = new Size(100, 19);
            radioNaoFuncional.TabIndex = 10;
            radioNaoFuncional.TabStop = true;
            radioNaoFuncional.Text = "Não funcional";
            radioNaoFuncional.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(49, 260);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(106, 36);
            btnCadastrarItem.TabIndex = 11;
            btnCadastrarItem.Text = "Cadastrar";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            btnCadastrarItem.Click += btnCadastrarItem_Click;
            // 
            // btnCancelarItem
            // 
            btnCancelarItem.Location = new Point(273, 260);
            btnCancelarItem.Name = "btnCancelarItem";
            btnCancelarItem.Size = new Size(106, 36);
            btnCancelarItem.TabIndex = 12;
            btnCancelarItem.Text = "Cancelar";
            btnCancelarItem.UseVisualStyleBackColor = true;
            btnCancelarItem.Click += btnCancelarItem_Click;
            // 
            // btnEditarItem
            // 
            btnEditarItem.Location = new Point(161, 260);
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.Size = new Size(106, 36);
            btnEditarItem.TabIndex = 13;
            btnEditarItem.Text = "Editar";
            btnEditarItem.UseVisualStyleBackColor = true;
            btnEditarItem.Click += btnEditarItem_Click;
            // 
            // txtIdItem
            // 
            txtIdItem.Location = new Point(25, 56);
            txtIdItem.Name = "txtIdItem";
            txtIdItem.Size = new Size(16, 23);
            txtIdItem.TabIndex = 14;
            txtIdItem.Visible = false;
            // 
            // FormAdicionarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 321);
            Controls.Add(txtIdItem);
            Controls.Add(btnEditarItem);
            Controls.Add(btnCancelarItem);
            Controls.Add(btnCadastrarItem);
            Controls.Add(radioNaoFuncional);
            Controls.Add(radioConserto);
            Controls.Add(radioFuncional);
            Controls.Add(txtNomeItem);
            Controls.Add(numQuantidadeItem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelAdicionarItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdicionarItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdicionarItem";
            Load += FormAdicionarItem_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label5;
        public Button btnCadastrarItem;
        public Button btnCancelarItem;
        public Button btnEditarItem;
        public NumericUpDown numQuantidadeItem;
        public TextBox txtNomeItem;
        public TextBox txtIdItem;
        public RadioButton radioFuncional;
        public RadioButton radioConserto;
        public RadioButton radioNaoFuncional;
        public Label labelAdicionarItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class FormEstoque : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public FormEstoque()
        {
            InitializeComponent();
            LoadEstoque();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }

        public void LoadEstoque()
        {
            dgvItens.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM item", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvItens.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            FormAdicionarItem formAdicionarItem = new FormAdicionarItem();
            formAdicionarItem.btnCadastrarItem.Enabled = true;
            formAdicionarItem.btnEditarItem.Enabled = false;
            formAdicionarItem.ShowDialog();
            LoadEstoque();
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvItens.Columns[e.ColumnIndex].Name;
            if (colName == "Editar")
            {
                FormAdicionarItem formAdicionarItem = new FormAdicionarItem();
                formAdicionarItem.labelAdicionarItem.Text = "Editar item";
                formAdicionarItem.txtIdItem.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                formAdicionarItem.txtNomeItem.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                formAdicionarItem.numQuantidadeItem.Value = Convert.ToDecimal(dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString());
                if(dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString() == "Em conserto")
                {
                    formAdicionarItem.radioConserto.Checked = true;
                }
                else if(dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString() == "Não funcional")
                {
                    formAdicionarItem.radioNaoFuncional.Checked = true;
                }

                formAdicionarItem.btnCadastrarItem.Enabled = false;
                formAdicionarItem.btnEditarItem.Enabled = true;
                formAdicionarItem.ShowDialog();
                LoadEstoque();
            }
            else if(colName == "Excluir")
            {
                if(MessageBox.Show("Tem certeza que deseja excluir esse item?", "Excluir Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM item WHERE id_Item="+ Convert.ToInt32(dgvItens.Rows[e.RowIndex].Cells[0].Value), con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadEstoque();
                }
            }
        }
    }
}

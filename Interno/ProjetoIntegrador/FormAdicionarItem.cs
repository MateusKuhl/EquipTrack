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
    public partial class FormAdicionarItem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public FormAdicionarItem()
        {
            InitializeComponent();
            radioFuncional.Checked = true;
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            string radioSelecionado = "";

            if (radioFuncional.Checked)
            {
                radioSelecionado = radioFuncional.Text;
            }
            else if (radioConserto.Checked)
            {
                radioSelecionado = radioConserto.Text;
            }
            else if (radioNaoFuncional.Checked)
            {
                radioSelecionado = radioNaoFuncional.Text;
            }

            if (txtNomeItem.Text != "" )
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja cadastrar esse item?", "Cadastrar Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("INSERT INTO item(nome_Item,quantidade_Item,situacao_Item)VALUES('" + txtNomeItem.Text.Trim() + "','" + Convert.ToInt32(numQuantidadeItem.Value) + "','" + radioSelecionado + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Item cadastrado com sucesso!");
                        txtNomeItem.Clear();
                        numQuantidadeItem.Value = 1;
                        radioFuncional.Checked = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void FormAdicionarItem_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            string radioSelecionado = "";

            if (radioFuncional.Checked)
            {
                radioSelecionado = radioFuncional.Text;
            }
            else if (radioConserto.Checked)
            {
                radioSelecionado = radioConserto.Text;
            }
            else if (radioNaoFuncional.Checked)
            {
                radioSelecionado = radioNaoFuncional.Text;
            }

            if (txtNomeItem.Text != "" )
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja editar esse item?", "Editar Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("UPDATE item SET nome_Item='" + txtNomeItem.Text.Trim() + "', quantidade_Item=" + Convert.ToInt32(numQuantidadeItem.Value) + ", situacao_Item='" + radioSelecionado + "' WHERE id_Item= " + Convert.ToInt32(txtIdItem.Text) + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Item editado com sucesso!");
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}

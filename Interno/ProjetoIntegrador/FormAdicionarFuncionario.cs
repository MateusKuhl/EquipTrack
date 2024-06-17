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
    public partial class FormAdicionarFuncionario : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public FormAdicionarFuncionario()
        {
            InitializeComponent();
            radioFuncionario.Checked = true;
        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            string radioSelecionado = "";

            if (radioFuncionario.Checked)
            {
                radioSelecionado = radioFuncionario.Text;
            }
            else if (radioProfessor.Checked)
            {
                radioSelecionado = radioProfessor.Text;
            }

            if (txtNomeFuncionario.Text != "" && txtEmailFuncionario.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja cadastrar esse funcionário?", "Cadastrar Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("INSERT INTO funcionario(nome_Funcionario,cargo_Funcionario,email_Funcionario)VALUES('" + txtNomeFuncionario.Text.Trim() + "','" + radioSelecionado + "','" + txtEmailFuncionario.Text.Trim() + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                        txtNomeFuncionario.Clear();
                        txtEmailFuncionario.Clear();
                        radioFuncionario.Checked = true;
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

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            string radioSelecionado = "";

            if (radioFuncionario.Checked)
            {
                radioSelecionado = radioFuncionario.Text;
            }
            else if (radioProfessor.Checked)
            {
                radioSelecionado = radioProfessor.Text;
            }


            if (txtNomeFuncionario.Text != "" && txtEmailFuncionario.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja editar esse funcionário?", "Editar Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("UPDATE funcionario SET nome_Funcionario='" + txtNomeFuncionario.Text.Trim() + "', cargo_Funcionario='" + radioSelecionado + "', email_Funcionario='" + txtEmailFuncionario.Text.Trim() + "' WHERE id_Funcionario= " + Convert.ToInt32(txtIdFuncionario.Text) + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Funcionário editado com sucesso!");
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

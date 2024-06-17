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
    public partial class FormCadastrarLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public FormCadastrarLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtRA.MaskCompleted)
                {
                    MessageBox.Show("Preencha o RA!");
                }
                else if (txtSenha.Text.Trim() != txtConfirmarSenha.Text.Trim())
                {
                    MessageBox.Show("As senhas não coincidem");
                }
                else if (MessageBox.Show("Tem certeza que deseja cadastrar esse usuário?", "Cadastrar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO login(ra,senha)VALUES('" + txtRA.Text + "', '" + txtSenha.Text.Trim() + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

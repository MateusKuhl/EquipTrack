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
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarSenha.Checked == false)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else if (checkBoxMostrarSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM login WHERE ra='" + txtRa.Text + "' AND senha='" + txtSenha.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("RA ou senha inválidos!", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarLogin_Click(object sender, EventArgs e)
        {
            FormCadastrarLogin formCadastrarLogin = new FormCadastrarLogin();
            formCadastrarLogin.ShowDialog();
        }
    }
}

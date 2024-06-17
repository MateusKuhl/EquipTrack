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
    public partial class FormFuncionarios : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public FormFuncionarios()
        {
            InitializeComponent();
            LoadFuncionarios();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }
        public void LoadFuncionarios()
        {
            dgvFuncionarios.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM funcionario", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvFuncionarios.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            FormAdicionarFuncionario formAdicionarFuncionario = new FormAdicionarFuncionario();
            formAdicionarFuncionario.btnCadastrarFuncionario.Enabled = true;
            formAdicionarFuncionario.btnEditarFuncionario.Enabled = false;
            formAdicionarFuncionario.ShowDialog();
            LoadFuncionarios();
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvFuncionarios.Columns[e.ColumnIndex].Name;
            if (colName == "Editar")
            {
                FormAdicionarFuncionario formAdicionarFuncionario = new FormAdicionarFuncionario();
                formAdicionarFuncionario.labelAdicionarFuncionario.Text = "Editar funcionário";
                formAdicionarFuncionario.txtIdFuncionario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                formAdicionarFuncionario.txtNomeFuncionario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                formAdicionarFuncionario.txtEmailFuncionario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString() == "Funcionário")
                {
                    formAdicionarFuncionario.radioFuncionario.Checked = true;
                }
                else if (dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString() == "Professor")
                {
                    formAdicionarFuncionario.radioProfessor.Checked = true;
                }

                formAdicionarFuncionario.btnCadastrarFuncionario.Enabled = false;
                formAdicionarFuncionario.btnEditarFuncionario.Enabled = true;
                formAdicionarFuncionario.ShowDialog();
                LoadFuncionarios();
            }
            else if (colName == "Excluir")
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse funcionário?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM funcionario WHERE id_Funcionario=" + Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value), con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadFuncionarios();
                }
            }
        }
    }
}

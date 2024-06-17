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
    public partial class FormAgendamentos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public FormAgendamentos()
        {
            InitializeComponent();
            LoadAgendamentos();
        }

        public void LoadAgendamentos()
        {
            dgvAgendamentos.Rows.Clear();
            cmd = new SqlCommand("SELECT af.id_Agendamentos,f.nome_Funcionario,i.nome_Item,ia.quantidade_Itens,af.data_Agendamento,af.horario,af.bloco,af.sala FROM agenda_funcionario af JOIN funcionario f on af.id_Funcionario = f.id_Funcionario JOIN item_agenda ia on af.id_Agendamentos = ia.id_Agendamentos JOIN item i on ia.id_Item = i.id_Item WHERE situacao_Agendamento='Em aberto'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvAgendamentos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4].ToString()).ToString("dd/MM/yyyy"), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdicionarAgendamento_Click(object sender, EventArgs e)
        {
            FormAdicionarAgendamento adicionarAgendamento = new FormAdicionarAgendamento();
            adicionarAgendamento.btnAgendar.Enabled = true;
            adicionarAgendamento.btnEditarAgendamento.Enabled = false;
            adicionarAgendamento.ShowDialog();
            LoadAgendamentos();
        }

        private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAgendamentos.Columns[e.ColumnIndex].Name;
            if (colName == "Editar")
            {
                FormAdicionarAgendamento formAdicionarAgendamento = new FormAdicionarAgendamento();
                formAdicionarAgendamento.txtIdAgendamento.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
                formAdicionarAgendamento.txtNomeFuncionario.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
                formAdicionarAgendamento.txtNomeItem.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
                formAdicionarAgendamento.numQuantidadeItem.Value = Convert.ToDecimal(dgvAgendamentos.Rows[e.RowIndex].Cells[3].Value.ToString());
                formAdicionarAgendamento.dateDataAgendamento.Value = Convert.ToDateTime(dgvAgendamentos.Rows[e.RowIndex].Cells[4].Value.ToString());
                formAdicionarAgendamento.txtHorario1.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0,5);
                formAdicionarAgendamento.txtHorario2.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(6, 5);
                formAdicionarAgendamento.txtBloco.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAdicionarAgendamento.txtSala.Text = dgvAgendamentos.Rows[e.RowIndex].Cells[7].Value.ToString();

                formAdicionarAgendamento.dgvFuncionarios.Enabled = false;
                formAdicionarAgendamento.dgvItens.Enabled = false;
                formAdicionarAgendamento.btnAgendar.Enabled = false;
                formAdicionarAgendamento.btnEditarAgendamento.Enabled = true;
                formAdicionarAgendamento.ShowDialog();
                LoadAgendamentos();
            }
            else if (colName == "Excluir")
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse agendamento?", "Excluir Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM item_agenda WHERE id_Agendamentos=" + Convert.ToInt32(dgvAgendamentos.Rows[e.RowIndex].Cells[0].Value) + "", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM agenda_funcionario WHERE id_Agendamentos=" + Convert.ToInt32(dgvAgendamentos.Rows[e.RowIndex].Cells[0].Value), con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE item SET quantidade_Item=(quantidade_Item+" + Convert.ToInt32(dgvAgendamentos.Rows[e.RowIndex].Cells[3].Value) + ") WHERE nome_Item='" + dgvAgendamentos.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadAgendamentos();
                }
            }
            else if(colName == "Baixa")
            {
                if (MessageBox.Show("Tem certeza que deseja dar baixa nesse agendamento?", "Dar Baixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE item SET quantidade_Item=(quantidade_Item+" + Convert.ToInt32(dgvAgendamentos.Rows[e.RowIndex].Cells[3].Value) + ") WHERE nome_Item='" + dgvAgendamentos.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE agenda_funcionario SET situacao_Agendamento='Finalizado' WHERE id_Agendamentos=" + Convert.ToInt32(dgvAgendamentos.Rows[e.RowIndex].Cells[0].Value) + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Baixa realizada com sucesso!");
                    LoadAgendamentos();
                }
            }
        }
    }
}

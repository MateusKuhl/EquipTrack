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
    public partial class FormAdicionarAgendamento : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int quantidade = 0;
        int quantidadeInicial = 0;
        public FormAdicionarAgendamento()
        {
            InitializeComponent();
            LoadFuncionarios();
            LoadItens();
        }
        public void LoadItens()
        {
            dgvItens.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM item WHERE CONCAT(id_Item,nome_Item,situacao_Item,quantidade_Item) LIKE '%" + txtProcurarItem.Text + "%' AND situacao_Item = 'Funcional' AND quantidade_Item>0", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvItens.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadFuncionarios()
        {
            dgvFuncionarios.Rows.Clear();
            cmd = new SqlCommand("SELECT id_Funcionario,nome_Funcionario FROM funcionario WHERE CONCAT(id_funcionario,nome_Funcionario) LIKE '%" + txtProcurarFuncionario.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvFuncionarios.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdicionarAgendamento_Load(object sender, EventArgs e)
        {
            quantidadeInicial = Convert.ToInt32(numQuantidadeItem.Value);
        }

        private void txtProcurarFuncionario_TextChanged(object sender, EventArgs e)
        {
            LoadFuncionarios();
        }

        private void txtProcurarItem_TextChanged(object sender, EventArgs e)
        {
            LoadItens();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numQuantidadeItem_ValueChanged(object sender, EventArgs e)
        {
            GetQuantidade();
            if (Convert.ToInt32(numQuantidadeItem.Value) > quantidade)
            {
                MessageBox.Show("Quantidade em estoque insuficiente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantidadeItem.Value = quantidade;
                return;
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdFuncionario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeFuncionario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdItem.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeItem.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdFuncionario.Text == "")
                {
                    MessageBox.Show("Selecione um funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtIdItem.Text == "")
                {
                    MessageBox.Show("Selecione um item!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!txtHorario1.MaskCompleted || !txtHorario2.MaskCompleted)
                {
                    MessageBox.Show("Preencha o horário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Tem certeza que deseja incluir esse agendamento?", "Incluir Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO agenda_funcionario(id_Funcionario,data_Agendamento,horario,situacao_Agendamento,bloco,sala)VALUES(" + txtIdFuncionario.Text + ",'" + dateDataAgendamento.Value + "','" + txtHorario1.Text + "-" + txtHorario2.Text + "','Em aberto','" + txtBloco.Text + "','" + txtSala.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("SELECT Convert(int, SCOPE_IDENTITY())", con);
                    int scopeIdentity = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("INSERT INTO item_agenda(id_Item,id_Agendamentos,quantidade_Itens)VALUES(" + Convert.ToInt32(txtIdItem.Text) + "," + scopeIdentity + "," + Convert.ToInt32(numQuantidadeItem.Value) + ")", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Agendamento incluido com sucesso!");

                    cmd = new SqlCommand("UPDATE item SET quantidade_Item=(quantidade_Item-" + Convert.ToInt32(numQuantidadeItem.Value) + ") WHERE id_Item LIKE '" + txtIdItem.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void GetQuantidade()
        {
            cmd = new SqlCommand("SELECT quantidade_Item FROM item WHERE nome_Item='" + txtNomeItem.Text + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quantidade = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnEditarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtHorario1.MaskCompleted || !txtHorario2.MaskCompleted)
                {
                    MessageBox.Show("Preencha o horário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Tem certeza que deseja editar esse agendamento?", "Editar Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE agenda_funcionario SET data_Agendamento='" + dateDataAgendamento.Value + "', horario='" + txtHorario1.Text + "-" + txtHorario2.Text + "', bloco='" + txtBloco.Text + "', sala='" + txtSala.Text + "' WHERE id_Agendamentos = " + Convert.ToInt32(txtIdAgendamento.Text) + "", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE item_agenda SET quantidade_Itens=" + Convert.ToInt32(numQuantidadeItem.Value) + "  WHERE id_Agendamentos=" + Convert.ToInt32(txtIdAgendamento.Text) + "", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (Convert.ToInt32(numQuantidadeItem.Value) > quantidadeInicial)
                    {
                        int quantidadeFinal = Convert.ToInt32(numQuantidadeItem.Value) - quantidadeInicial;
                        cmd = new SqlCommand("UPDATE item SET quantidade_Item=(quantidade_Item-" + quantidadeFinal + ") WHERE nome_Item= '" + txtNomeItem.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (quantidadeInicial > Convert.ToInt32(numQuantidadeItem.Value))
                    {
                        int quantidadeFinal = quantidadeInicial - Convert.ToInt32(numQuantidadeItem.Value);
                        cmd = new SqlCommand("UPDATE item SET quantidade_Item=(quantidade_Item+" + quantidadeFinal + ") WHERE nome_Item= '" + txtNomeItem.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Agendamento editado com sucesso!");

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

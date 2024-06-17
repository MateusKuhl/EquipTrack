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
    public partial class FormRelatorios : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public FormRelatorios()
        {
            InitializeComponent();
            LoadAgendamentos();
            LoadFuncionarios();
            LoadItens();
        }

        public void LoadAgendamentos()
        {
            dgvAgendamentos.Rows.Clear();
            cmd = new SqlCommand("SELECT af.id_Agendamentos,f.nome_Funcionario,i.nome_Item,ia.quantidade_Itens,af.data_Agendamento,af.horario,af.bloco,af.sala FROM agenda_funcionario af JOIN funcionario f on af.id_Funcionario = f.id_Funcionario JOIN item_agenda ia on af.id_Agendamentos = ia.id_Agendamentos JOIN item i on ia.id_Item = i.id_Item WHERE situacao_Agendamento='Finalizado'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvAgendamentos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4].ToString()).ToString("dd/MM/yyyy"), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadFuncionarios()
        {
            dgvFuncionariosUtilizaram.Rows.Clear();
            cmd = new SqlCommand("SELECT f.nome_Funcionario, COUNT(af.id_Agendamentos) as agendamentos FROM agenda_funcionario af JOIN funcionario f ON f.id_Funcionario = af.id_Funcionario GROUP BY f.nome_Funcionario ORDER BY agendamentos DESC", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvFuncionariosUtilizaram.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadItens()
        {
            dgvItensUtilizados.Rows.Clear();
            cmd = new SqlCommand("SELECT i.nome_Item, SUM(ia.quantidade_Itens) as total FROM item_agenda ia JOIN item i ON ia.id_Item = i.id_Item GROUP BY i.nome_Item ORDER BY total DESC", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvItensUtilizados.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}

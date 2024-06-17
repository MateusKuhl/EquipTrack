using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoIntegrador
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KUHL;Initial Catalog=gestao_de_acessorios;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();

        public MainForm()
        {
            InitializeComponent();

            this.pnlFormLoader.Controls.Clear();
            FormEstoque formEstoque_Vrb = new FormEstoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formEstoque_Vrb);
            formEstoque_Vrb.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormEstoque formEstoque_Vrb = new FormEstoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formEstoque_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formEstoque_Vrb);
            formEstoque_Vrb.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormFuncionarios formFuncionarios_Vrb = new FormFuncionarios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formFuncionarios_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formFuncionarios_Vrb);
            formFuncionarios_Vrb.Show();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormAgendamentos formAgendamentos_Vrb = new FormAgendamentos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAgendamentos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formAgendamentos_Vrb);
            formAgendamentos_Vrb.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormRelatorios formRelatorios_Vrb = new FormRelatorios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formRelatorios_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(formRelatorios_Vrb);
            formRelatorios_Vrb.Show();
        }
    }
}

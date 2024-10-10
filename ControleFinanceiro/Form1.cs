using ControleFinanceiro.Model;

namespace ControleFinanceiro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void VerificarCaixasPreenchidas()
        {
            if (txtNome.Text != "" && txtCpf.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            lstClientes.Items.Add(cliente.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1) // Verifica se algum item está selecionado
            {
                lstClientes.Items.RemoveAt(lstClientes.SelectedIndex); // Remove o item selecionado
                btnExcluir.Enabled = false; // Desativa o botão de exclusão
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lstClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                    }
    }


}

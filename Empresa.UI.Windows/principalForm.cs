namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm() => InitializeComponent();

        private void novoClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clienteIncluirForm form = new clienteIncluirForm();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ClientesForm();
            f.ShowDialog();


        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fornecedor = new FornecedorForm();
            fornecedor.ShowDialog();
        }
    }
}
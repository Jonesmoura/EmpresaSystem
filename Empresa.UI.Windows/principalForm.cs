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
    }
}
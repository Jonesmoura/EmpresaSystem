using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.DB;
using Empresa.Models;


namespace Empresa.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            ExcluirButton.Visible = true;
            SairButton.Visible = true;
            ConfirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarIncluirButton.Visible = false;
            VoltarButton.Visible = false;

            var db = new ClienteDB();

            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = false;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;
            listaDataGridView.Columns["Id"].Width = 50;

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();

        }


        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            ConfirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarIncluirButton.Visible = true;
            LimparFicha();
        }

        private void LimparFicha()
        {

            idTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telTextBox.Clear();

            idTextBox.Focus();
        }

        private void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;
            novoButton.Visible = false;
            alterarButton.Visible = false;
            ExcluirButton.Visible = false;
            SairButton.Visible = false;
            ConfirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarIncluirButton.Visible = true;
            VoltarButton.Visible = true;
        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void ConfirmarIncluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telTextBox.Text;

            var db = new ClienteDB();
            db.Incluir(cliente);

            ExibirGrid();

        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            var cliente = (cliente)listaDataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telTextBox.Text = cliente.Telefone;
            ExibirFicha();

            ConfirmarAlterarButton.Visible = true;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarIncluirButton.Visible = false;

        }

        private void ConfirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telTextBox.Text;

            var db = new ClienteDB();
            db.Alterar(cliente);

            ExibirGrid();

        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = (cliente)listaDataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telTextBox.Text = cliente.Telefone;
            ExibirFicha();

            ConfirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = true;
            ConfirmarIncluirButton.Visible = false;
        }

        private void ConfirmarExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telTextBox.Text;

            var db = new ClienteDB();
            db.Excluir(cliente.Id);

            ExibirGrid();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

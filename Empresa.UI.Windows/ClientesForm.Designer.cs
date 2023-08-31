namespace Empresa.UI.Windows
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            novoButton = new Button();
            alterarButton = new Button();
            ExcluirButton = new Button();
            SairButton = new Button();
            ConfirmarIncluirButton = new Button();
            ConfirmarAlterarButton = new Button();
            ConfirmarExcluirButton = new Button();
            VoltarButton = new Button();
            conteudoPanel = new Panel();
            fichaPanel = new Panel();
            telTextBox = new TextBox();
            telLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            nomeTextBox = new TextBox();
            NomeLabel = new Label();
            idTextBox = new TextBox();
            idLabel = new Label();
            listaDataGridView = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            conteudoPanel.SuspendLayout();
            fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 71);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(novoButton);
            flowLayoutPanel1.Controls.Add(alterarButton);
            flowLayoutPanel1.Controls.Add(ExcluirButton);
            flowLayoutPanel1.Controls.Add(SairButton);
            flowLayoutPanel1.Controls.Add(ConfirmarIncluirButton);
            flowLayoutPanel1.Controls.Add(ConfirmarAlterarButton);
            flowLayoutPanel1.Controls.Add(ConfirmarExcluirButton);
            flowLayoutPanel1.Controls.Add(VoltarButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(762, 71);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            novoButton.Location = new Point(13, 10);
            novoButton.Name = "novoButton";
            novoButton.Size = new Size(75, 23);
            novoButton.TabIndex = 0;
            novoButton.Text = "Novo";
            novoButton.UseVisualStyleBackColor = true;
            novoButton.Click += novoButton_Click;
            // 
            // alterarButton
            // 
            alterarButton.Location = new Point(94, 10);
            alterarButton.Name = "alterarButton";
            alterarButton.Size = new Size(75, 23);
            alterarButton.TabIndex = 1;
            alterarButton.Text = "Alterar";
            alterarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            ExcluirButton.Location = new Point(175, 10);
            ExcluirButton.Name = "ExcluirButton";
            ExcluirButton.Size = new Size(75, 23);
            ExcluirButton.TabIndex = 2;
            ExcluirButton.Text = "Excluir";
            ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // SairButton
            // 
            SairButton.Location = new Point(256, 10);
            SairButton.Name = "SairButton";
            SairButton.Size = new Size(75, 23);
            SairButton.TabIndex = 3;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarIncluirButton
            // 
            ConfirmarIncluirButton.Location = new Point(337, 10);
            ConfirmarIncluirButton.Name = "ConfirmarIncluirButton";
            ConfirmarIncluirButton.Size = new Size(75, 23);
            ConfirmarIncluirButton.TabIndex = 4;
            ConfirmarIncluirButton.Text = "Gravar";
            ConfirmarIncluirButton.UseVisualStyleBackColor = true;
            ConfirmarIncluirButton.Click += ConfirmarIncluirButton_Click;
            // 
            // ConfirmarAlterarButton
            // 
            ConfirmarAlterarButton.Location = new Point(418, 10);
            ConfirmarAlterarButton.Name = "ConfirmarAlterarButton";
            ConfirmarAlterarButton.Size = new Size(75, 23);
            ConfirmarAlterarButton.TabIndex = 5;
            ConfirmarAlterarButton.Text = "Alterar";
            ConfirmarAlterarButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarExcluirButton
            // 
            ConfirmarExcluirButton.Location = new Point(499, 10);
            ConfirmarExcluirButton.Name = "ConfirmarExcluirButton";
            ConfirmarExcluirButton.Size = new Size(123, 23);
            ConfirmarExcluirButton.TabIndex = 6;
            ConfirmarExcluirButton.Text = "Confirmar Exclusão";
            ConfirmarExcluirButton.UseVisualStyleBackColor = true;
            // 
            // VoltarButton
            // 
            VoltarButton.Location = new Point(628, 10);
            VoltarButton.Name = "VoltarButton";
            VoltarButton.Size = new Size(75, 23);
            VoltarButton.TabIndex = 7;
            VoltarButton.Text = "Voltar";
            VoltarButton.UseVisualStyleBackColor = true;
            VoltarButton.Click += VoltarButton_Click;
            // 
            // conteudoPanel
            // 
            conteudoPanel.Controls.Add(fichaPanel);
            conteudoPanel.Controls.Add(listaDataGridView);
            conteudoPanel.Dock = DockStyle.Fill;
            conteudoPanel.Location = new Point(0, 0);
            conteudoPanel.Name = "conteudoPanel";
            conteudoPanel.Padding = new Padding(10);
            conteudoPanel.Size = new Size(762, 402);
            conteudoPanel.TabIndex = 1;
            // 
            // fichaPanel
            // 
            fichaPanel.Controls.Add(telTextBox);
            fichaPanel.Controls.Add(telLabel);
            fichaPanel.Controls.Add(emailTextBox);
            fichaPanel.Controls.Add(emailLabel);
            fichaPanel.Controls.Add(nomeTextBox);
            fichaPanel.Controls.Add(NomeLabel);
            fichaPanel.Controls.Add(idTextBox);
            fichaPanel.Controls.Add(idLabel);
            fichaPanel.Location = new Point(27, 12);
            fichaPanel.Name = "fichaPanel";
            fichaPanel.Size = new Size(331, 302);
            fichaPanel.TabIndex = 1;
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(136, 118);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(149, 23);
            telTextBox.TabIndex = 6;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new Point(57, 121);
            telLabel.Name = "telLabel";
            telLabel.Size = new Size(54, 15);
            telLabel.TabIndex = 2;
            telLabel.Text = "Telefone:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(136, 89);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(149, 23);
            emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(57, 92);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(136, 60);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(149, 23);
            nomeTextBox.TabIndex = 8;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(57, 63);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(43, 15);
            NomeLabel.TabIndex = 4;
            NomeLabel.Text = "Nome:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(136, 31);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(149, 23);
            idTextBox.TabIndex = 9;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(57, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 15);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // listaDataGridView
            // 
            listaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaDataGridView.Location = new Point(384, 12);
            listaDataGridView.Name = "listaDataGridView";
            listaDataGridView.RowTemplate.Height = 25;
            listaDataGridView.Size = new Size(365, 302);
            listaDataGridView.TabIndex = 0;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 473);
            Controls.Add(conteudoPanel);
            Controls.Add(panel1);
            Name = "ClientesForm";
            Text = "Clientes";
            Load += ClientesForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            conteudoPanel.ResumeLayout(false);
            fichaPanel.ResumeLayout(false);
            fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button novoButton;
        private Button alterarButton;
        private Button ExcluirButton;
        private Button SairButton;
        private Button ConfirmarIncluirButton;
        private Button ConfirmarAlterarButton;
        private Button ConfirmarExcluirButton;
        private Panel conteudoPanel;
        private Panel fichaPanel;
        private DataGridView listaDataGridView;
        private TextBox telTextBox;
        private Label telLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox nomeTextBox;
        private Label NomeLabel;
        private TextBox idTextBox;
        private Label idLabel;
        private Button VoltarButton;
    }
}
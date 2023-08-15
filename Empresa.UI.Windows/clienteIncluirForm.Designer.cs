namespace Empresa.UI.Windows
{
    partial class clienteIncluirForm
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
            idLabel = new Label();
            idTextBox = new TextBox();
            NomeLabel = new Label();
            nomeTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            telLabel = new Label();
            telTextBox = new TextBox();
            incluirButton = new Button();
            voltarButton = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(105, 54);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(184, 51);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(149, 23);
            idTextBox.TabIndex = 1;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(105, 83);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(43, 15);
            NomeLabel.TabIndex = 0;
            NomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(184, 80);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(149, 23);
            nomeTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(105, 112);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(184, 109);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(149, 23);
            emailTextBox.TabIndex = 1;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new Point(105, 141);
            telLabel.Name = "telLabel";
            telLabel.Size = new Size(54, 15);
            telLabel.TabIndex = 0;
            telLabel.Text = "Telefone:";
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(184, 138);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(149, 23);
            telTextBox.TabIndex = 1;
            // 
            // incluirButton
            // 
            incluirButton.Location = new Point(199, 181);
            incluirButton.Name = "incluirButton";
            incluirButton.Size = new Size(64, 32);
            incluirButton.TabIndex = 2;
            incluirButton.Text = "Incluir";
            incluirButton.UseVisualStyleBackColor = true;
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(269, 181);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(64, 32);
            voltarButton.TabIndex = 2;
            voltarButton.Text = "Voltar";
            voltarButton.UseVisualStyleBackColor = true;
            // 
            // clienteIncluirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(voltarButton);
            Controls.Add(incluirButton);
            Controls.Add(telTextBox);
            Controls.Add(telLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nomeTextBox);
            Controls.Add(NomeLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Name = "clienteIncluirForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private Label NomeLabel;
        private TextBox nomeTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label telLabel;
        private TextBox telTextBox;
        private Button incluirButton;
        private Button voltarButton;
    }
}
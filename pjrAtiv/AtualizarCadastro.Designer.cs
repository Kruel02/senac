namespace pjrAtiv
{
    partial class AtualizarCadastro
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
            TxtNome = new TextBox();
            TxtEndereco = new TextBox();
            TxtCidade = new TextBox();
            TxtEmail = new TextBox();
            TxtTelefone = new TextBox();
            TxtRG = new TextBox();
            TxtCPF = new TextBox();
            CBEstado = new ComboBox();
            CBCivil = new ComboBox();
            BtnAtualizar = new Button();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(21, 61);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Nome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 0;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(21, 114);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.PlaceholderText = "Endereço";
            TxtEndereco.Size = new Size(100, 23);
            TxtEndereco.TabIndex = 1;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(21, 166);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "Cidade";
            TxtCidade.Size = new Size(100, 23);
            TxtCidade.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(21, 272);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 3;
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(213, 61);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.PlaceholderText = "Telefone";
            TxtTelefone.Size = new Size(100, 23);
            TxtTelefone.TabIndex = 4;
            // 
            // TxtRG
            // 
            TxtRG.Location = new Point(213, 114);
            TxtRG.Name = "TxtRG";
            TxtRG.PlaceholderText = "RG";
            TxtRG.Size = new Size(100, 23);
            TxtRG.TabIndex = 5;
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(213, 166);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.PlaceholderText = "CPF";
            TxtCPF.Size = new Size(100, 23);
            TxtCPF.TabIndex = 6;
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(21, 219);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(121, 23);
            CBEstado.TabIndex = 7;
            CBEstado.Text = "Estado";
            // 
            // CBCivil
            // 
            CBCivil.FormattingEnabled = true;
            CBCivil.Location = new Point(213, 219);
            CBCivil.Name = "CBCivil";
            CBCivil.Size = new Size(121, 23);
            CBCivil.TabIndex = 8;
            CBCivil.Text = "EstadoCivil";
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Location = new Point(214, 274);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 9;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // AtualizarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 379);
            Controls.Add(BtnAtualizar);
            Controls.Add(CBCivil);
            Controls.Add(CBEstado);
            Controls.Add(TxtCPF);
            Controls.Add(TxtRG);
            Controls.Add(TxtTelefone);
            Controls.Add(TxtEmail);
            Controls.Add(TxtCidade);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Name = "AtualizarCadastro";
            Text = "AtualizarCadastro";
            FormClosing += FecharJanelaAtualizar;
            Load += AtualizarCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtEndereco;
        private TextBox TxtCidade;
        private TextBox TxtEmail;
        private TextBox TxtTelefone;
        private TextBox TxtRG;
        private TextBox TxtCPF;
        private ComboBox CBEstado;
        private ComboBox CBCivil;
        private Button BtnAtualizar;
    }
}
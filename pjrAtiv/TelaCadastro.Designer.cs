namespace pjrAtiv
{
    partial class TelaCadastro
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
            TxtRG = new TextBox();
            TxtCPF = new TextBox();
            TxtEndereco = new TextBox();
            TxtTelefone = new TextBox();
            TxtEmail = new TextBox();
            TxtCidade = new TextBox();
            TxtSenha = new TextBox();
            DtNascimento = new DateTimePicker();
            BtnCadastrar = new Button();
            BtnLimpar = new Button();
            CbEstadoCivil = new ComboBox();
            CbEstado = new ComboBox();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(12, 44);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Nome";
            TxtNome.Size = new Size(125, 23);
            TxtNome.TabIndex = 0;
            TxtNome.TextChanged += textBox1_TextChanged;
            // 
            // TxtRG
            // 
            TxtRG.Location = new Point(12, 199);
            TxtRG.Name = "TxtRG";
            TxtRG.PlaceholderText = "RG";
            TxtRG.Size = new Size(125, 23);
            TxtRG.TabIndex = 1;
            TxtRG.TextChanged += TxtRG_TextChanged;
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(12, 251);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.PlaceholderText = "CPF";
            TxtCPF.Size = new Size(125, 23);
            TxtCPF.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(12, 306);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.PlaceholderText = "Endereço";
            TxtEndereco.Size = new Size(125, 23);
            TxtEndereco.TabIndex = 3;
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(209, 44);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.PlaceholderText = "Telefone";
            TxtTelefone.Size = new Size(125, 23);
            TxtTelefone.TabIndex = 4;
            TxtTelefone.TextChanged += TxtTelefone_TextChanged;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(209, 150);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(128, 23);
            TxtEmail.TabIndex = 5;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(12, 353);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "Cidade";
            TxtCidade.Size = new Size(125, 23);
            TxtCidade.TabIndex = 6;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(209, 196);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Senha";
            TxtSenha.Size = new Size(128, 23);
            TxtSenha.TabIndex = 7;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // DtNascimento
            // 
            DtNascimento.Location = new Point(12, 98);
            DtNascimento.Name = "DtNascimento";
            DtNascimento.Size = new Size(136, 23);
            DtNascimento.TabIndex = 9;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(212, 251);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 10;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(212, 296);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 11;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // CbEstadoCivil
            // 
            CbEstadoCivil.FormattingEnabled = true;
            CbEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado" });
            CbEstadoCivil.Location = new Point(12, 150);
            CbEstadoCivil.Name = "CbEstadoCivil";
            CbEstadoCivil.Size = new Size(125, 23);
            CbEstadoCivil.TabIndex = 12;
            CbEstadoCivil.Text = "Estado Civil";
            CbEstadoCivil.SelectedIndexChanged += CbEstadoCivil_SelectedIndexChanged;
            // 
            // CbEstado
            // 
            CbEstado.FormattingEnabled = true;
            CbEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            CbEstado.Location = new Point(209, 98);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(125, 23);
            CbEstado.TabIndex = 13;
            CbEstado.Text = "Estado";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 428);
            Controls.Add(CbEstado);
            Controls.Add(CbEstadoCivil);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnCadastrar);
            Controls.Add(DtNascimento);
            Controls.Add(TxtSenha);
            Controls.Add(TxtCidade);
            Controls.Add(TxtEmail);
            Controls.Add(TxtTelefone);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtCPF);
            Controls.Add(TxtRG);
            Controls.Add(TxtNome);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtRG;
        private TextBox TxtCPF;
        private TextBox TxtEndereco;
        private TextBox TxtTelefone;
        private TextBox TxtEmail;
        private TextBox TxtCidade;
        private TextBox TxtSenha;
        private DateTimePicker DtNascimento;
        private Button BtnCadastrar;
        private Button BtnLimpar;
        private ComboBox CbEstadoCivil;
        private ComboBox CbEstado;
    }
}
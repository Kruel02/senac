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
            LblNome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
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
            TxtCPF.TextChanged += TxtCPF_TextChanged;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(12, 305);
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
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(12, 26);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 14;
            LblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 80);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 15;
            label1.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 132);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 16;
            label2.Text = "Estado Cívil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 181);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 17;
            label3.Text = "RG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 233);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 18;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 287);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 335);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 20;
            label6.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 26);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 21;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 80);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 22;
            label8.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 132);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 23;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 178);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 24;
            label10.Text = "Senha";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 428);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblNome);
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
        private Label LblNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
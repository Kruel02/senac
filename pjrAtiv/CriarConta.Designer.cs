namespace pjrAtiv
{
    partial class CriarConta
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
            TxtSalario = new TextBox();
            TxtSenha = new TextBox();
            textBox1 = new TextBox();
            CBTipoConta = new ComboBox();
            BtnCadastrar = new Button();
            LblConta = new Label();
            SuspendLayout();
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(45, 99);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.PlaceholderText = "Salário";
            TxtSalario.Size = new Size(100, 23);
            TxtSalario.TabIndex = 0;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(45, 146);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Senha";
            TxtSenha.Size = new Size(100, 23);
            TxtSenha.TabIndex = 1;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 187);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Confirmar Senha";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CBTipoConta
            // 
            CBTipoConta.FormattingEnabled = true;
            CBTipoConta.Items.AddRange(new object[] { "Correntista", "Especial" });
            CBTipoConta.Location = new Point(45, 54);
            CBTipoConta.Name = "CBTipoConta";
            CBTipoConta.Size = new Size(100, 23);
            CBTipoConta.TabIndex = 3;
            CBTipoConta.Text = "Tipo de Conta";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(48, 234);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 4;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblConta
            // 
            LblConta.AutoSize = true;
            LblConta.Location = new Point(45, 20);
            LblConta.Name = "LblConta";
            LblConta.Size = new Size(115, 15);
            LblConta.TabIndex = 5;
            LblConta.Text = "Cadastre uma Conta";
            // 
            // CriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(196, 292);
            Controls.Add(LblConta);
            Controls.Add(BtnCadastrar);
            Controls.Add(CBTipoConta);
            Controls.Add(textBox1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtSalario);
            Name = "CriarConta";
            Text = "CriarConta";
            Load += CriarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSalario;
        private TextBox TxtSenha;
        private TextBox textBox1;
        private ComboBox CBTipoConta;
        private Button BtnCadastrar;
        private Label LblConta;
    }
}
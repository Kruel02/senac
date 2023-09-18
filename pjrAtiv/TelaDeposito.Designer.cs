namespace pjrAtiv
{
    partial class TelaDeposito
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
            lblDeposito = new Label();
            lblSaldo = new Label();
            lblValorDeposito = new Label();
            lblinsiraValor = new Label();
            txtValorDeposito = new TextBox();
            txtSenha = new TextBox();
            btnConfirmacao = new Button();
            lblMensagem = new Label();
            btnVoltarDeposito = new Button();
            lblValorSaque = new Label();
            SuspendLayout();
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Location = new Point(21, 19);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(54, 15);
            lblDeposito.TabIndex = 6;
            lblDeposito.Text = "Depósito";
            lblDeposito.Click += lblExtrato_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(21, 51);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 15);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo: 50.00";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Location = new Point(157, 116);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(89, 15);
            lblValorDeposito.TabIndex = 4;
            lblValorDeposito.Text = "Valor Depósito :";
            lblValorDeposito.Visible = false;
            lblValorDeposito.Click += lblNomeCliente_Click;
            // 
            // lblinsiraValor
            // 
            lblinsiraValor.AutoSize = true;
            lblinsiraValor.Location = new Point(157, 79);
            lblinsiraValor.Name = "lblinsiraValor";
            lblinsiraValor.Size = new Size(191, 15);
            lblinsiraValor.TabIndex = 7;
            lblinsiraValor.Text = "Insira o valor que deseja depositar :";
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(157, 134);
            txtValorDeposito.MaxLength = 12;
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.Size = new Size(191, 23);
            txtValorDeposito.TabIndex = 8;
            txtValorDeposito.TextChanged += txtValorDeposito_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(157, 176);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(191, 23);
            txtSenha.TabIndex = 9;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnConfirmacao
            // 
            btnConfirmacao.Location = new Point(157, 226);
            btnConfirmacao.Name = "btnConfirmacao";
            btnConfirmacao.Size = new Size(191, 23);
            btnConfirmacao.TabIndex = 10;
            btnConfirmacao.Text = "Confirmar Depósito ";
            btnConfirmacao.UseVisualStyleBackColor = true;
            btnConfirmacao.Click += button1_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(157, 267);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(92, 15);
            lblMensagem.TabIndex = 11;
            lblMensagem.Text = "Depósito  Feito !";
            lblMensagem.Visible = false;
            // 
            // btnVoltarDeposito
            // 
            btnVoltarDeposito.Location = new Point(273, 316);
            btnVoltarDeposito.Name = "btnVoltarDeposito";
            btnVoltarDeposito.Size = new Size(75, 23);
            btnVoltarDeposito.TabIndex = 12;
            btnVoltarDeposito.Text = "Fechar";
            btnVoltarDeposito.UseVisualStyleBackColor = true;
            btnVoltarDeposito.Click += btnVoltarDeposito_Click;
            // 
            // lblValorSaque
            // 
            lblValorSaque.AutoSize = true;
            lblValorSaque.Location = new Point(157, 160);
            lblValorSaque.Name = "lblValorSaque";
            lblValorSaque.Size = new Size(39, 15);
            lblValorSaque.TabIndex = 14;
            lblValorSaque.Text = "Senha";
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 370);
            Controls.Add(lblValorSaque);
            Controls.Add(btnVoltarDeposito);
            Controls.Add(lblMensagem);
            Controls.Add(btnConfirmacao);
            Controls.Add(txtSenha);
            Controls.Add(txtValorDeposito);
            Controls.Add(lblinsiraValor);
            Controls.Add(lblDeposito);
            Controls.Add(lblSaldo);
            Controls.Add(lblValorDeposito);
            Name = "TelaDeposito";
            Load += TelaDeposito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeposito;
        private Label lblSaldo;
        private Label lblValorDeposito;
        private Label lblinsiraValor;
        private TextBox txtValorDeposito;
        private TextBox txtSenha;
        private Button btnConfirmacao;
        private Label lblMensagem;
        private Button btnVoltarDeposito;
        private Label lblValorSaque;
    }
}
namespace pjrAtiv
{
    partial class TelaSaque
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
            btnVoltarSaque = new Button();
            lblMensagem = new Label();
            btnConfirmacao = new Button();
            txtSenha = new TextBox();
            txtValorDeposito = new TextBox();
            lblinsiraValor = new Label();
            lblSaque = new Label();
            lblSaldo = new Label();
            lblValorSaque = new Label();
            SuspendLayout();
            // 
            // btnVoltarSaque
            // 
            btnVoltarSaque.Location = new Point(659, 395);
            btnVoltarSaque.Name = "btnVoltarSaque";
            btnVoltarSaque.Size = new Size(75, 23);
            btnVoltarSaque.TabIndex = 21;
            btnVoltarSaque.Text = "Voltar";
            btnVoltarSaque.UseVisualStyleBackColor = true;
            btnVoltarSaque.Click += btnVoltarSaque_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(543, 290);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(77, 15);
            lblMensagem.TabIndex = 20;
            lblMensagem.Text = "Saque  Feito !";
            // 
            // btnConfirmacao
            // 
            btnConfirmacao.Location = new Point(543, 249);
            btnConfirmacao.Name = "btnConfirmacao";
            btnConfirmacao.Size = new Size(191, 23);
            btnConfirmacao.TabIndex = 19;
            btnConfirmacao.Text = "Confirmar Saque  ";
            btnConfirmacao.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(543, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha:****";
            txtSenha.Size = new Size(191, 23);
            txtSenha.TabIndex = 18;
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(543, 157);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "00,00";
            txtValorDeposito.Size = new Size(191, 23);
            txtValorDeposito.TabIndex = 17;
            // 
            // lblinsiraValor
            // 
            lblinsiraValor.AutoSize = true;
            lblinsiraValor.Location = new Point(543, 102);
            lblinsiraValor.Name = "lblinsiraValor";
            lblinsiraValor.Size = new Size(169, 15);
            lblinsiraValor.TabIndex = 16;
            lblinsiraValor.Text = "Insira o valor que deseja sacar :";
            // 
            // lblSaque
            // 
            lblSaque.AutoSize = true;
            lblSaque.Location = new Point(66, 32);
            lblSaque.Name = "lblSaque";
            lblSaque.Size = new Size(42, 15);
            lblSaque.TabIndex = 15;
            lblSaque.Text = "Saque ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(66, 64);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 15);
            lblSaldo.TabIndex = 14;
            lblSaldo.Text = "Saldo: 50.00";
            // 
            // lblValorSaque
            // 
            lblValorSaque.AutoSize = true;
            lblValorSaque.Location = new Point(543, 32);
            lblValorSaque.Name = "lblValorSaque";
            lblValorSaque.Size = new Size(74, 15);
            lblValorSaque.TabIndex = 13;
            lblValorSaque.Text = "Valor Saque :";
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarSaque);
            Controls.Add(lblMensagem);
            Controls.Add(btnConfirmacao);
            Controls.Add(txtSenha);
            Controls.Add(txtValorDeposito);
            Controls.Add(lblinsiraValor);
            Controls.Add(lblSaque);
            Controls.Add(lblSaldo);
            Controls.Add(lblValorSaque);
            Name = "TelaSaque";
            Text = "TelaSaque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarSaque;
        private Label lblMensagem;
        private Button btnConfirmacao;
        private TextBox txtSenha;
        private TextBox txtValorDeposito;
        private Label lblinsiraValor;
        private Label lblSaque;
        private Label lblSaldo;
        private Label lblValorSaque;
    }
}
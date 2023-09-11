namespace pjrAtiv
{
    partial class TelaMenu
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
            lblNomeCliente = new Label();
            lblSaldo = new Label();
            lblExtrato = new Label();
            lsbExtrato = new ListBox();
            btnConfig = new Button();
            lblOperacoes = new Label();
            btnDepositar = new Button();
            btnSacar = new Button();
            btnPragarTrans = new Button();
            btnEncerrar = new Button();
            SuspendLayout();
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(39, 24);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(58, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "Olá, Arley";
            lblNomeCliente.Click += label1_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(39, 63);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 15);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo: 50.00";
            // 
            // lblExtrato
            // 
            lblExtrato.AutoSize = true;
            lblExtrato.Location = new Point(39, 103);
            lblExtrato.Name = "lblExtrato";
            lblExtrato.Size = new Size(47, 15);
            lblExtrato.TabIndex = 3;
            lblExtrato.Text = "Extrato:";
            // 
            // lsbExtrato
            // 
            lsbExtrato.FormattingEnabled = true;
            lsbExtrato.ItemHeight = 15;
            lsbExtrato.Location = new Point(39, 162);
            lsbExtrato.Name = "lsbExtrato";
            lsbExtrato.Size = new Size(245, 169);
            lsbExtrato.TabIndex = 4;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(107, 383);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(94, 23);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // lblOperacoes
            // 
            lblOperacoes.AutoSize = true;
            lblOperacoes.Location = new Point(412, 24);
            lblOperacoes.Name = "lblOperacoes";
            lblOperacoes.Size = new Size(66, 15);
            lblOperacoes.TabIndex = 6;
            lblOperacoes.Text = "Operações:";
            lblOperacoes.Click += label1_Click_1;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(427, 103);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(174, 23);
            btnDepositar.TabIndex = 7;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += button1_Click;
            btnDepositar.MouseClick += btn_deposito_voltar;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(427, 183);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(174, 23);
            btnSacar.TabIndex = 8;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnPragarTrans
            // 
            btnPragarTrans.Location = new Point(427, 263);
            btnPragarTrans.Name = "btnPragarTrans";
            btnPragarTrans.Size = new Size(174, 23);
            btnPragarTrans.TabIndex = 9;
            btnPragarTrans.Text = "Transferencia";
            btnPragarTrans.UseVisualStyleBackColor = true;
            btnPragarTrans.Click += btnTransferencia_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Location = new Point(463, 383);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(75, 23);
            btnEncerrar.TabIndex = 10;
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseVisualStyleBackColor = true;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEncerrar);
            Controls.Add(btnPragarTrans);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(lblOperacoes);
            Controls.Add(btnConfig);
            Controls.Add(lsbExtrato);
            Controls.Add(lblExtrato);
            Controls.Add(lblSaldo);
            Controls.Add(lblNomeCliente);
            Name = "TelaMenu";
            Text = "TelaMenu";
            Load += TelaMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNomeCliente;
        private Label lblSaldo;
        private Label lblExtrato;
        private ListBox lsbExtrato;
        private Button btnConfig;
        private Label lblOperacoes;
        private Button btnDepositar;
        private Button btnSacar;
        private Button btnPragarTrans;
        private Button btnEncerrar;
    }
}
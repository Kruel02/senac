namespace pjrAtiv
{
    partial class Banco
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
            menuStrip1 = new MenuStrip();
            contaToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            transferenciaToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarContaToolStripMenuItem = new ToolStripMenuItem();
            nomeClienteToolStripMenuItem = new ToolStripMenuItem();
            iDContaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contaToolStripMenuItem, operaçõesToolStripMenuItem, nomeClienteToolStripMenuItem, iDContaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(979, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logOutToolStripMenuItem, cadastroToolStripMenuItem, fecharToolStripMenuItem });
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(121, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(121, 22);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(121, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(121, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, depositoToolStripMenuItem, transferenciaToolStripMenuItem, saqueToolStripMenuItem, alterarDadosToolStripMenuItem, alterarContaToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            operaçõesToolStripMenuItem.Click += operaçõesToolStripMenuItem_Click;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(145, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(145, 22);
            depositoToolStripMenuItem.Text = "Deposito";
            depositoToolStripMenuItem.Click += depositoToolStripMenuItem_Click;
            // 
            // transferenciaToolStripMenuItem
            // 
            transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            transferenciaToolStripMenuItem.Size = new Size(145, 22);
            transferenciaToolStripMenuItem.Text = "Transferencia";
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(145, 22);
            saqueToolStripMenuItem.Text = "Saque";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(145, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            alterarDadosToolStripMenuItem.Click += alterarDadosToolStripMenuItem_Click;
            // 
            // alterarContaToolStripMenuItem
            // 
            alterarContaToolStripMenuItem.Name = "alterarContaToolStripMenuItem";
            alterarContaToolStripMenuItem.Size = new Size(145, 22);
            alterarContaToolStripMenuItem.Text = "Alterar Conta";
            alterarContaToolStripMenuItem.Click += alterarContaToolStripMenuItem_Click;
            // 
            // nomeClienteToolStripMenuItem
            // 
            nomeClienteToolStripMenuItem.Name = "nomeClienteToolStripMenuItem";
            nomeClienteToolStripMenuItem.Size = new Size(89, 20);
            nomeClienteToolStripMenuItem.Text = "NomeCliente";
            nomeClienteToolStripMenuItem.Click += nomeClienteToolStripMenuItem_Click;
            // 
            // iDContaToolStripMenuItem
            // 
            iDContaToolStripMenuItem.Name = "iDContaToolStripMenuItem";
            iDContaToolStripMenuItem.Size = new Size(62, 20);
            iDContaToolStripMenuItem.Text = "IDConta";
            iDContaToolStripMenuItem.DropDownOpening += ContaTeste;
            iDContaToolStripMenuItem.DropDownOpened += ContasAbertas;
            iDContaToolStripMenuItem.DropDownItemClicked += AlterarConta;
            iDContaToolStripMenuItem.Click += iDContaToolStripMenuItem_Click;
            // 
            // Banco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 547);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Banco";
            Text = "Banco";
            FormClosing += Fechar;
            Load += Banco_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem transferenciaToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem nomeClienteToolStripMenuItem;
        private ToolStripMenuItem iDContaToolStripMenuItem;
        private ToolStripMenuItem alterarContaToolStripMenuItem;
    }
}
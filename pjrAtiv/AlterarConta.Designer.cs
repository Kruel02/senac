﻿namespace pjrAtiv
{
    partial class AlterarConta
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
            CBContas = new ComboBox();
            TxtSenha = new TextBox();
            BtnAtualizar = new Button();
            SuspendLayout();
            // 
            // CBContas
            // 
            CBContas.FormattingEnabled = true;
            CBContas.Location = new Point(56, 84);
            CBContas.Name = "CBContas";
            CBContas.Size = new Size(196, 23);
            CBContas.TabIndex = 0;
            CBContas.Text = "Contas";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(56, 143);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(196, 23);
            TxtSenha.TabIndex = 1;
            TxtSenha.Text = "Senha";
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Location = new Point(115, 208);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 2;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // AlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 284);
            Controls.Add(BtnAtualizar);
            Controls.Add(TxtSenha);
            Controls.Add(CBContas);
            Name = "AlterarConta";
            Text = "AlterarConta";
            Load += AlterarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBContas;
        private TextBox TxtSenha;
        private Button BtnAtualizar;
    }
}
namespace pjrAtiv
{
    partial class TelaLogin
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
            TxtSenha = new TextBox();
            Btn_Login = new Button();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(34, 66);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Email ou CPF";
            TxtNome.Size = new Size(175, 23);
            TxtNome.TabIndex = 0;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(34, 125);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PlaceholderText = "Senha";
            TxtSenha.Size = new Size(175, 23);
            TxtSenha.TabIndex = 1;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // Btn_Login
            // 
            Btn_Login.Location = new Point(47, 187);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(75, 23);
            Btn_Login.TabIndex = 2;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = true;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 307);
            Controls.Add(Btn_Login);
            Controls.Add(TxtSenha);
            Controls.Add(TxtNome);
            Name = "TelaLogin";
            Text = "TelaLogin";
            FormClosed += LoginClose;
            Load += TelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtSenha;
        private Button Btn_Login;
    }
}
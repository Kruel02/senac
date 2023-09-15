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
            label4 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(34, 66);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(175, 23);
            TxtNome.TabIndex = 0;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(34, 125);
            TxtSenha.Name = "TxtSenha";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 48);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 19;
            label4.Text = "CPF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 107);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 25;
            label10.Text = "Senha";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 307);
            Controls.Add(label10);
            Controls.Add(label4);
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
        private Label label4;
        private Label label10;
    }
}
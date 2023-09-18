namespace pjrAtiv
{
    partial class AtualizarCadastro
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
            TxtEndereco = new TextBox();
            TxtCidade = new TextBox();
            TxtEmail = new TextBox();
            TxtTelefone = new TextBox();
            TxtRG = new TextBox();
            TxtCPF = new TextBox();
            CBEstado = new ComboBox();
            CBCivil = new ComboBox();
            BtnAtualizar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            LblNome = new Label();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(21, 61);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Nome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 0;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(21, 114);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.PlaceholderText = "Endereço";
            TxtEndereco.Size = new Size(100, 23);
            TxtEndereco.TabIndex = 1;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(21, 166);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.PlaceholderText = "Cidade";
            TxtCidade.Size = new Size(100, 23);
            TxtCidade.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(21, 272);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 4;
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(213, 61);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.PlaceholderText = "Telefone";
            TxtTelefone.Size = new Size(100, 23);
            TxtTelefone.TabIndex = 5;
            // 
            // TxtRG
            // 
            TxtRG.Location = new Point(213, 114);
            TxtRG.Name = "TxtRG";
            TxtRG.PlaceholderText = "RG";
            TxtRG.Size = new Size(100, 23);
            TxtRG.TabIndex = 6;
            TxtRG.TextChanged += TxtRG_TextChanged;
            // 
            // TxtCPF
            // 
            TxtCPF.Location = new Point(213, 166);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.PlaceholderText = "CPF";
            TxtCPF.Size = new Size(100, 23);
            TxtCPF.TabIndex = 7;
            TxtCPF.TextChanged += TxtCPF_TextChanged;
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(21, 219);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(121, 23);
            CBEstado.TabIndex = 3;
            CBEstado.Text = "Estado";
            // 
            // CBCivil
            // 
            CBCivil.FormattingEnabled = true;
            CBCivil.Location = new Point(213, 219);
            CBCivil.Name = "CBCivil";
            CBCivil.Size = new Size(121, 23);
            CBCivil.TabIndex = 8;
            CBCivil.Text = "EstadoCivil";
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Location = new Point(214, 274);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 9;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 254);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 34;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 201);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 33;
            label8.Text = "Estado";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 43);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 32;
            label7.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 149);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 31;
            label6.Text = "Cidade";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 96);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 30;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 149);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 29;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 96);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 28;
            label3.Text = "RG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 201);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 27;
            label2.Text = "Estado Cívil";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(21, 43);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 25;
            LblNome.Text = "Nome";
            // 
            // AtualizarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 379);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblNome);
            Controls.Add(BtnAtualizar);
            Controls.Add(CBCivil);
            Controls.Add(CBEstado);
            Controls.Add(TxtCPF);
            Controls.Add(TxtRG);
            Controls.Add(TxtTelefone);
            Controls.Add(TxtEmail);
            Controls.Add(TxtCidade);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Name = "AtualizarCadastro";
            Text = "AtualizarCadastro";
            FormClosing += FecharJanelaAtualizar;
            Load += AtualizarCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtEndereco;
        private TextBox TxtCidade;
        private TextBox TxtEmail;
        private TextBox TxtTelefone;
        private TextBox TxtRG;
        private TextBox TxtCPF;
        private ComboBox CBEstado;
        private ComboBox CBCivil;
        private Button BtnAtualizar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label LblNome;
    }
}
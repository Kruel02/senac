using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;

namespace pjrAtiv
{
    public partial class CriarConta : Form
    {



        public CriarConta()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            CBTipoConta.Text = "Correntista";
            TxtSalario.Text = 10000.ToString();
            if(BtnCadastrar.TabIndex == 4) 
            {
                CBTipoConta.Focus();
            
            
            }




        }

        private void CriarConta_Load(object sender, EventArgs e)
        {
            if (UsuarioLogado.Id == 0)
            {

                MessageBox.Show("Nenhum Usuario Logado");
                foreach (TextBox box in this.Controls.OfType<TextBox>())
                {
                    box.Enabled = false;

                    BtnCadastrar.Enabled = false;
                }
                foreach (ComboBox Combo in this.Controls.OfType<ComboBox>())
                {
                    Combo.Enabled = false;

                }


            }

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSenha.Text == UsuarioLogado.Senha && textBox1.Text == UsuarioLogado.Senha)
                {

                    SqlCommand cmd;
                    SqlConnection conexao;
                    Conta cliente;
                    cmd = new SqlCommand();
                    conexao = new SqlConnection();
                    cliente = new Conta(UsuarioLogado.Id, Convert.ToDecimal(TxtSalario.Text), "Ativa");

                    conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";
                    cmd.Connection = conexao;
                    cmd.CommandText = "pi_Conta_48";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCorrentista", UsuarioLogado.Id);
                    cmd.Parameters.AddWithValue("TipoConta", CBTipoConta.Text);
                    cmd.Parameters.AddWithValue("saldo", Convert.ToDecimal(TxtSalario.Text));
                    cmd.Parameters.AddWithValue("statusConta", "Ativa");


                    conexao.Open();
                    cliente.IdConta = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show(cliente.IdConta.ToString() + "Conta Criada com Sucesso");


                    conexao.Close();
                    Application.OpenForms["banco"].MainMenuStrip.Items["iDContaToolStripMenuItem"].Text = cliente.IdConta.ToString();
                }
                else
                {
                    MessageBox.Show("Senha errada");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {

            string value = TxtSalario.Text.Replace(",", "")
  .Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            // Verifica se estamos lidando com um número válido
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                // Desinscreve o evento para evitar um loop
                TxtSalario.TextChanged -= TxtSalario_TextChanged;
                // Formata o texto como moeda
                TxtSalario.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:N2}", ul);
                TxtSalario.TextChanged += TxtSalario_TextChanged;
                TxtSalario.Select(TxtSalario.Text.Length, 0);


            }
        }
    }
}

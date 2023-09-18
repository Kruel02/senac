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
using System.Windows;
using System.Globalization;

namespace pjrAtiv
{
    public partial class TelaSaque : Form
    {
        public TelaSaque()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();

        }

        private void btnVoltarSaque_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {


        }

        private void txtValorDeposito_TextChanged(object sender, EventArgs e)
        {
            
                string value = txtValorDeposito.Text.Replace(",", "")
      .Replace("$", "").Replace(".", "").TrimStart('0');
                decimal ul;
                // Verifica se estamos lidando com um número válido
                if (decimal.TryParse(value, out ul))
                {
                    ul /= 100;
                    // Desinscreve o evento para evitar um loop
                    txtValorDeposito.TextChanged -= txtValorDeposito_TextChanged;
                    // Formata o texto como moeda
                    txtValorDeposito.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:N2}", ul);
                    txtValorDeposito.TextChanged += txtValorDeposito_TextChanged;
                    txtValorDeposito.Select(txtValorDeposito.Text.Length, 0);
                }

        }
        

        private void TelaSaque_Load(object sender, EventArgs e)
        {

            foreach (var item in UsuarioLogado.Contas)
            {
                if (item.IdConta == UsuarioLogado.ContaLogada)
                {
                    lblSaldo.Text = item.Saldo.ToString();


                }


            }

        }

        private void btnConfirmacao_Click(object sender, EventArgs e)
        {
            if (txtValorDeposito.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor");

            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DepositoSaldo";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

                cmd.Connection = conexao;
                conexao.Open();


                //limpando parametros
                cmd.Parameters.Clear();


                cmd.Parameters.AddWithValue("ContaId", UsuarioLogado.ContaLogada);




                if (txtSenha.Text != UsuarioLogado.Senha)
                {

                    MessageBox.Show("Senha incorreta");

                }
                else
                {

                    foreach (var item in UsuarioLogado.Contas)
                    {
                        if (item.VerDinheiro(Convert.ToDecimal(txtValorDeposito.Text)))
                        {
                            MessageBox.Show("Não pode sacar mais do que tem");
                            break;

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("SaldoConta", item.SaldoDinheiro(Convert.ToDecimal(txtValorDeposito.Text)));
                            MessageBox.Show(item.Saldo.ToString());
                            lblSaldo.Text = item.Saldo.ToString();
                            Int32 rowsAffected = cmd.ExecuteNonQuery();
                            conexao.Close();
                            break;
                        }


                    }



                    if (Application.OpenForms.OfType<TelaDeposito>().Any())
                    {
                        foreach (System.Windows.Forms.Label label in Application.OpenForms["TelaDeposito"].Controls.OfType<System.Windows.Forms.Label>())
                        {
                            if (label.Name == "lblSaldo")
                            {


                                label.Text = this.lblSaldo.Text;




                            }
                        }



                    }

                }




            }
        }

        private void lblinsiraValor_Click(object sender, EventArgs e)
        {

        }
    }
}

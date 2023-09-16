using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace pjrAtiv
{
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();
        }
        private string _laststring;

        private void TelaDeposito_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
            {
                if(item.IdConta == UsuarioLogado.ContaLogada) 
                {
                    lblSaldo.Text = item.Saldo.ToString();
                    break;

                }
               

            }
         
        }

        private void lblValorDeposito_Click(object sender, EventArgs e)
        {
        }

        private void lblInsiraValor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void lblExtrato_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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

                    cmd.Parameters.AddWithValue("SaldoConta", item.Depositar(Convert.ToDecimal(txtValorDeposito.Text)));
                    MessageBox.Show(item.Saldo.ToString());
                    lblSaldo.Text = item.Saldo.ToString();
                    break;

                }

                Int32 rowsAffected = cmd.ExecuteNonQuery();


            }

          
            if (Application.OpenForms.OfType<TelaSaque>().Any())
            {
                foreach (System.Windows.Forms.Label label in Application.OpenForms["TelaSaque"].Controls.OfType<System.Windows.Forms.Label>())
                {
                    if (label.Name == "lblSaldo")
                    {


                        label.Text = this.lblSaldo.Text;


                        

                    }
                }
                


            }

            conexao.Close();



        }

        private void btnVoltarDeposito_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtValorDeposito_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(txtValorDeposito.Text, out int Val) == false)
            {
                string input = txtValorDeposito.Text;

                string numbersOnly = new string(input.Where(char.IsDigit).ToArray());

                txtValorDeposito.Text = numbersOnly;

                txtValorDeposito.SelectionStart = txtValorDeposito.Text.Length;

            }


        }
    }
}

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

namespace pjrAtiv
{
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {

            InitializeComponent();
        }
        private string _laststring;

        private void TelaDeposito_Load(object sender, EventArgs e)
        {

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
            cmd.CommandText = "AtualizarConta";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

            cmd.Connection = conexao;
            conexao.Open();

            //limpando parametros
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("SaldoConta", txtValorDeposito.Text);
            cmd.Parameters.AddWithValue("TipoConta", UsuarioLogado.ContaLogada);
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

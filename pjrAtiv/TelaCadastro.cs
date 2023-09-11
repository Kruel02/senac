using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{

    public partial class TelaCadastro : Form
    {
        MethodCall metodo = new MethodCall();
        CriarConta CadastrarConta;
        public TelaCadastro()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            int stringlen = rng.Next(4, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number.
                randValue = rng.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string.
                str = str + letter;
            }

            MethodCall Metodo = new MethodCall();
            TxtNome.Text = str;
            TxtEndereco.Text = rng.Next(1,9999).ToString();
            TxtCidade.Text = rng.Next(0,555555).ToString();
            CbEstado.Text = "São Paulo";
            TxtCPF.Text = rng.Next(55555, 999999999).ToString();
            TxtRG.Text = rng.Next(0, 99999999).ToString();
            TxtSenha.Text = rng.Next(0, 5555).ToString();
            CbEstadoCivil.Text = "Solteiro";
            TxtTelefone.Text = rng.Next(1111, 99999).ToString();
            TxtEmail.Text = rng.Next(1, 999999999).ToString();



        }

        private void CbTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            metodo.Controls = this.Controls;
            metodo.LimparTextBoxes();
        }



        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {




            foreach (TextBox box in this.Controls.OfType<TextBox>())
            {
                if (box.Text == string.Empty || box.Text == "" || box.Text == null)
                {
                    MessageBox.Show("Põe valor ae");
                    break;
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";
                    cmd.CommandText = "CadastrarCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nomeCliente", TxtNome.Text);
                    cmd.Parameters.AddWithValue("EnderecoCliente", TxtEndereco.Text);
                    cmd.Parameters.AddWithValue("ClienteNascimento", Convert.ToDateTime(DtNascimento.Text));
                    cmd.Parameters.AddWithValue("CidadeCliente", TxtCidade.Text);
                    cmd.Parameters.AddWithValue("EstadoCliente", CbEstado.Text);
                    cmd.Parameters.AddWithValue("ClienteEmail", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("TelefoneCliente", TxtTelefone.Text);
                    cmd.Parameters.AddWithValue("ClienteRG", TxtRG.Text);
                    cmd.Parameters.AddWithValue("ClienteCPF", TxtCPF.Text);
                    cmd.Parameters.AddWithValue("ClienteSenha", TxtSenha.Text);
                    cmd.Parameters.AddWithValue("DataCriacao", DateTime.Now);
                    cmd.Parameters.AddWithValue("EstadoCivil", CbEstadoCivil.Text);
                    cmd.Parameters.AddWithValue("UltimoLogin", DateTime.Now);


                    Int32 rowsAffected = cmd.ExecuteNonQuery();


                    if (rowsAffected == -1)
                    {
                        MessageBox.Show("Não cadastrado" + rowsAffected);


                    }
                    else
                    {
                        MessageBox.Show("Usuario Cadastrado");
                        conn.Close();
                        MessageBox.Show("Cadastre uma conta");
                        


                    }
                    break;
                }



            }

            


        }

        private void CbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

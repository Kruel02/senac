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
    public partial class AtualizarCadastro : Form
    {
        public AtualizarCadastro()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void AtualizarCadastro_Load(object sender, EventArgs e)
        {
            if (UsuarioLogado.Id == 0)
            {
                MessageBox.Show("Nenhum Usuario Logado");
                foreach (TextBox box in this.Controls.OfType<TextBox>())
                {
                    box.Enabled = false;

                    BtnAtualizar.Enabled = false;
                }
                foreach (ComboBox Combo in this.Controls.OfType<ComboBox>())
                {
                    Combo.Enabled = false;
                    
                }
            }
            else
            {
                TxtNome.Text = UsuarioLogado.Nome;
                TxtEndereco.Text = UsuarioLogado.Endereco;
                TxtCidade.Text = UsuarioLogado.Cidade;
                TxtEmail.Text = UsuarioLogado.Email;
                TxtTelefone.Text = UsuarioLogado.Telefone;
                TxtRG.Text = UsuarioLogado.RG;
                TxtCPF.Text = UsuarioLogado.CPF;
                CBEstado.Text = UsuarioLogado.EstadoCliente;
                CBCivil.Text = UsuarioLogado.EstadoCivil;
                
            }



        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";
            cmd.CommandText = "AtualizarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("ClienteId", UsuarioLogado.Id.ToString());
            cmd.Parameters.AddWithValue("Clientenome", TxtNome.Text);
            cmd.Parameters.AddWithValue("EnderecoCliente", TxtEndereco.Text);
            cmd.Parameters.AddWithValue("Cidadecliente", TxtCidade.Text);
            cmd.Parameters.AddWithValue("EstadoCliente", CBEstado.Text);
            cmd.Parameters.AddWithValue("EmailCliente", TxtEmail.Text);
            cmd.Parameters.AddWithValue("telefone", TxtTelefone.Text);
            cmd.Parameters.AddWithValue("cpf", TxtCPF.Text.Trim());
            cmd.Parameters.AddWithValue("rg", TxtRG.Text);
            cmd.Parameters.AddWithValue("EstadoCivil", CBCivil.Text);
            cmd.Parameters.AddWithValue("ClienteNascimento", UsuarioLogado.DataNascimento);

            Int32 rowsAffected = cmd.ExecuteNonQuery();


            if (rowsAffected == -1)
            {
                MessageBox.Show("Não não atualizado" + rowsAffected);


            }
            else
            {
                MessageBox.Show("Usuario atualizado");
                conn.Close();
                



            }

        }

        private void FecharJanelaAtualizar(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}

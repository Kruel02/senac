using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Security.Cryptography;

namespace pjrAtiv
{
    public partial class TelaLogin : Form
    {
        MethodCall call;
        Conta conta;
        Cliente cliente;
        CriarConta CadastrarConta;

        public TelaLogin()
        {

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }


        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            call = new MethodCall();

            Conta conta = new Conta();
            Banco f = this.MdiParent as Banco;
            //ParentForm.MainMenuStrip.Items[].Enabled = false;


            //ParentForm.MainMenuStrip.Items.Add("teste");
            call.Controls = this.MdiParent.Controls;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ValidarLogin48";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

            cmd.Connection = conexao;
            conexao.Open();

            //limpando parametros
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", TxtNome.Text);
            cmd.Parameters.AddWithValue("senha", TxtSenha.Text);

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();

                TxtNome.Text = leitor.GetString("ClienteCPF");
                TxtSenha.Text = leitor.GetString("ClienteSenha");
                UsuarioLogado.Id = Convert.ToInt32(leitor.GetValue(0));
                UsuarioLogado.Nome = leitor.GetString(1);
                UsuarioLogado.Endereco = leitor.GetString(2);
                UsuarioLogado.Cidade = leitor.GetString(3);
                UsuarioLogado.DataNascimento = leitor.GetDateTime(4);
                UsuarioLogado.EstadoCliente = leitor.GetString(5);
                UsuarioLogado.EstadoCivil = leitor.GetString(6);
                UsuarioLogado.Email = leitor.GetString(7);
                UsuarioLogado.Telefone = leitor.GetString(8);
                UsuarioLogado.RG = leitor.GetString(9);
                UsuarioLogado.CPF = leitor.GetString(10);
                UsuarioLogado.Senha = leitor.GetString(11);
                UsuarioLogado.DataCriacao = leitor.GetDateTime(12);
                UsuarioLogado.UltimoLogin = leitor.GetDateTime(13);


                MessageBox.Show("bem vindo" + "" + leitor.GetString(1) + UsuarioLogado.CPF + UsuarioLogado.ContaLogada.ToString());

                Application.OpenForms["banco"].MainMenuStrip.Items["operaçõesToolStripMenuItem"].Enabled = true;
                Application.OpenForms["banco"].MainMenuStrip.Items["nomeClienteToolStripMenuItem"].Visible = true;
                Application.OpenForms["banco"].MainMenuStrip.Items["nomeClienteToolStripMenuItem"].Text = UsuarioLogado.Nome;

                this.Close();

                call.MenuStrips("menuStrip1", "loginToolStripMenuItem", false);
                call.MenuStrips("menuStrip1", "logOutToolStripMenuItem", true);
                call.MenuStrips("menuStrip1", "cadastroToolStripMenuItem", false);




            }
            else
            {
                MessageBox.Show("Não logou.");
            }
            conexao.Close();
            leitor.Close();

            cmd.CommandText = "BuscarContaporIDCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            conexao.Open();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("IdCliente", UsuarioLogado.Id);
            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())

                {
                    Conta conta1 = new Conta(leitor.GetInt32(0), leitor.GetInt32(1), leitor.GetDecimal(3), leitor.GetString(2));
                    UsuarioLogado.Contas.Add(conta1);




                }
                UsuarioLogado.ContaLogada = UsuarioLogado.Contas[0].IdConta;
                Application.OpenForms["banco"].MainMenuStrip.Items[3].Visible = true;
                Application.OpenForms["banco"].MainMenuStrip.Items[3].Text = UsuarioLogado.ContaLogada.ToString();
                Application.OpenForms["banco"].MainMenuStrip.Items[3].Enabled = true;



            }
            conexao.Close();
            leitor.Close();











            //verificar se há linhas retornadas do leitor


            //f.loginToolStripMenuItem.Enabled = false;
            
        }

        private void Strip_ItemAdded(object? sender, ToolStripItemEventArgs e)
        {
            throw new NotImplementedException();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            TxtNome.Text = "4069";
            TxtSenha.Text = "123";
        }


        private void LoginClose(object sender, FormClosedEventArgs e)
        {



            Control[] controls = this.MdiParent.Controls.Find("menuStrip1", true);
            foreach (Control control in controls)
            {
                if (control.Name == "menuStrip1")
                {
                    MenuStrip strip = control as MenuStrip;
                    foreach (ToolStripMenuItem SubMenu in strip.Items)
                    {

                        foreach (ToolStripItem SubmenuItem in SubMenu.DropDownItems)
                        {
                            if (SubmenuItem.Name == "loginToolStripMenuItem")
                            {
                                SubmenuItem.Enabled = true;
                                if (SubMenu.Name == "logOutToolStripMenuItem")
                                {
                                    SubMenu.Enabled = false;
                                }


                            }

                        }

                    }


                }
            }






        }

    }


}


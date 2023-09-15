using pjrAtiv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace pjrAtiv
{

    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            logOutToolStripMenuItem.Enabled = false;
            



        }
        MethodCall call;
        SqlCommand cmd = new SqlCommand();




        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TelaCadastro cadastro = new TelaCadastro();



            if (Application.OpenForms.OfType<TelaCadastro>().Any())
            {
                Application.OpenForms.OfType<TelaCadastro>().First().Close();



            }

            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TelaLogin login = new TelaLogin();
            login.StartPosition = FormStartPosition.WindowsDefaultLocation;


            if (Application.OpenForms.OfType<TelaLogin>().Any())
            {

                Application.OpenForms.OfType<TelaLogin>().First().Close();


            }


            login.MdiParent = this;


            login.Show();



        }

        private void Banco_Load(object sender, EventArgs e)
        {
            if (UsuarioLogado.Id == 0)
            {
                operaçõesToolStripMenuItem.Enabled = false;




            }
            else
            {
                operaçõesToolStripMenuItem.Enabled = true;
            }

            if (UsuarioLogado.Id == 0)
            {
                nomeClienteToolStripMenuItem.Enabled = false;
                nomeClienteToolStripMenuItem.Visible = false;
            }



            if (UsuarioLogado.ContaLogada == 0)
            {
                iDContaToolStripMenuItem.Enabled = false;
                iDContaToolStripMenuItem.Visible = false;

            }

            
            


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call = new MethodCall();

            call.Controls = this.Controls;
            call.MenuStrips("menuStrip1", "logOutToolStripMenuItem", false);
            call.MenuStrips("menuStrip1", "loginToolStripMenuItem", true);
            cmd.CommandText = "UpdateTime";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

            cmd.Connection = conexao;
            conexao.Open();

            //limpando parametros
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("UltimoLogin", DateTime.Now);
            cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.Id);



            Int32 rowsAffected = cmd.ExecuteNonQuery();



            if (rowsAffected == -1)
            {
                MessageBox.Show("Não Atualizou, mas deslogou" + rowsAffected);


            }
            else
            {
                MessageBox.Show(rowsAffected.ToString() + UsuarioLogado.CPF);
            }
            conexao.Close();
            UsuarioLogado.Deslogar();
            operaçõesToolStripMenuItem.Enabled = false;

            nomeClienteToolStripMenuItem.Enabled = false;
            nomeClienteToolStripMenuItem.Visible = false;
            iDContaToolStripMenuItem.Visible = false;
            iDContaToolStripMenuItem.Enabled = false;
            cadastroToolStripMenuItem.Enabled = true;

           

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UpdateTime";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

            cmd.Connection = conexao;
            conexao.Open();

            //limpando parametros
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("UltimoLogin", DateTime.Now);
            cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.Id);



            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conexao.Close();
            UsuarioLogado.Deslogar();
            Application.Exit();
        }

        private void Fechar(object sender, FormClosingEventArgs e)
        {
            cmd.CommandText = "UpdateTime";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "workstation id=JukabankMOISES.mssql.somee.com;packet size=4096;user id=Moises90_SQLLogin_1;pwd=tjnwoa1ips;data source=JukabankMOISES.mssql.somee.com;persist security info=False;initial catalog=JukabankMOISES";

            cmd.Connection = conexao;
            conexao.Open();

            //limpando parametros
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("UltimoLogin", DateTime.Now);
            cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.Id);


            UsuarioLogado.Deslogar();
            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conexao.Close();
            Application.Exit();

        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarConta CadastrarConta;
            CadastrarConta = new CriarConta();
            if (Application.OpenForms.OfType<CriarConta>().Any())
            {

                Application.OpenForms.OfType<CriarConta>().First().Close();


            }
            CadastrarConta.MdiParent = this;
            CadastrarConta.Show();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarCadastro Atualizar = new AtualizarCadastro();


            if (Application.OpenForms.OfType<AtualizarCadastro>().Any())
            {

                Application.OpenForms.OfType<AtualizarCadastro>().First().Close();


            }
            Atualizar.MdiParent = this;
            Atualizar.Show();

        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeposito Deposito = new TelaDeposito();
            if (Application.OpenForms.OfType<TelaDeposito>().Any())
            {

                Application.OpenForms.OfType<TelaDeposito>().First().Close();


            }
            Deposito.MdiParent = this;
            Deposito.Show();

        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)

        {
            TelaSaque Saque = new TelaSaque();

            if (Application.OpenForms.OfType<TelaSaque>().Any())
            {

                Application.OpenForms.OfType<TelaSaque>().First().Close();


            }
            Saque.MdiParent = this;
            Saque.Show();

        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado.ContaLogada == 0)
            {
                depositoToolStripMenuItem.Enabled = false;
                saqueToolStripMenuItem.Enabled = false;
                transferenciaToolStripMenuItem.Enabled = false;
                alterarContaToolStripMenuItem.Enabled = false;


            }
            else if (UsuarioLogado.ContaLogada > 0 && operaçõesToolStripMenuItem.Pressed)
            {
                depositoToolStripMenuItem.Enabled = true;
                saqueToolStripMenuItem.Enabled = true;
                transferenciaToolStripMenuItem.Enabled = true;
                alterarContaToolStripMenuItem.Enabled = true;
            }

        }

        private void nomeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                if (UsuarioLogado.ContaLogada == 0)
                {
                    MessageBox.Show("Nõa há conta");

                }
                else
                {
                    AlterarConta ContaAtt = new AlterarConta();

                    ContaAtt.MdiParent = this;
                    ContaAtt.Show();

                }
                


            

           
        }

        private void iDContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ContasAbertas(object sender, EventArgs e)
        {



        }

        private void ContaTeste(object sender, EventArgs e)
        {
            iDContaToolStripMenuItem.Text = string.Empty;

            if (iDContaToolStripMenuItem.Text == string.Empty) 
            {
                foreach (var item in UsuarioLogado.Contas)
                {

                    iDContaToolStripMenuItem.DropDownItems.Add(item.IdConta.ToString());


                }
                iDContaToolStripMenuItem.Text = iDContaToolStripMenuItem.DropDown.Items[0].Text;
                
            }
                        

            if (logOutToolStripMenuItem.Pressed && iDContaToolStripMenuItem.Text != null)    
            {
                
            
            }

        }

        private void AlterarConta(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


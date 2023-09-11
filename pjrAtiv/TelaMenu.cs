using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pjrAtiv;
using DTO;
using DAL;




namespace pjrAtiv
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDeposito telaDeposito = new TelaDeposito();
            
            this.Close();
            telaDeposito.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {

        }

        private void btn_deposito_voltar(object sender, MouseEventArgs e)
        {
            
           
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            TelaSaque telaSaque = new TelaSaque();
            this.ActivateMdiChild(telaSaque);
            telaSaque.Show();
            this.Hide();
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

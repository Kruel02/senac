using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show(this);
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

        }

        private void btnVoltarDeposito_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Close();
            telaMenu.Show();
        }
    }
}

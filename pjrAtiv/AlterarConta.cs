using pjrAtiv.Classes;
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
    public partial class AlterarConta : Form
    {
        public AlterarConta()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void AlterarConta_Load(object sender, EventArgs e)
        {
            CBContas.Items.Clear();
            foreach (var item in UsuarioLogado.Contas)
            {
                CBContas.Items.Add(item.IdConta);
            }
            CBContas.Text = CBContas.Items[0].ToString();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (TxtSenha.Text == UsuarioLogado.Senha)
            {
                CBContas.Text = CBContas.Items[CBContas.SelectedIndex].ToString();
                UsuarioLogado.ContaLogada = Convert.ToInt32(CBContas.Text);
                Application.OpenForms["banco"].MainMenuStrip.Items["iDContaToolStripMenuItem"].Text = CBContas.Text;
                MessageBox.Show("Conta Alterada");
            }
            else 
            {

                MessageBox.Show("Senha errada");
            
            
            }
        }

        private void CBContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

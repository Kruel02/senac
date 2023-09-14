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
            foreach (var item in UsuarioLogado.Contas)
            {
                CBContas.Items.Add(item.IdConta);
            }
            CBContas.Text = CBContas.Items[0].ToString();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void CBContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

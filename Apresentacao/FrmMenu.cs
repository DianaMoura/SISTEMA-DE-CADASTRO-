using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmCL = new FrmClienteSelecionar();
            frmCL.MdiParent = this;
            frmCL.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

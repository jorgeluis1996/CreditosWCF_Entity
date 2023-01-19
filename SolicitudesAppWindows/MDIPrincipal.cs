using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudesAppWindows
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 objCliente01 = new ClienteMan01();
            objCliente01.MdiParent = this;
            objCliente01.Show();
        }

        private void garantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Garantia01 objGarantia01 = new Garantia01();
            objGarantia01.MdiParent = this;
            objGarantia01.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

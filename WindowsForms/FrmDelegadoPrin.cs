using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmDelegadoPrin : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmDelegadoMostrar frmMostrar;

        public FrmDelegadoPrin()
        {
            InitializeComponent();
        }

        private void FrmDelegadoPrin_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmDelegadoMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }
    }
}

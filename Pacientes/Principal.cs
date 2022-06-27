using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            lblmsgbar.Text = $"autenticado como{System.Security.Principal.WindowsIdentity.GetCurrent().Name}";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.MdiParent = this;
            user.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void iconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}

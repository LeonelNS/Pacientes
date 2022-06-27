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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtt_Click(object sender, EventArgs e)
        {
            if(User.Text=="admin" && Pass.Text == "admin")
            {
                var principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username o Password incorrectas", "gestor de pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtt_Click(object sender, EventArgs e)
        {
            User.Text = String.Empty;
            Pass.Text = String.Empty;   
        }
    }
}

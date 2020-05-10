using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealGolfApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboMainSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMainSelection.SelectedIndex == 1)
            {
                Form registerForm = new frmRegister();
                SQLConnection.OpenSqlConnection();
                registerForm.Show();
            }
            else if (cboMainSelection.SelectedIndex == 2)
            {
                Form loginForm = new frmLogin();
                loginForm.Show();
            }
            else if (cboMainSelection.SelectedIndex == 3)
            {
                Close();
            }
            else
            {
                cboMainSelection.Focus();
            }
        }
    }
}

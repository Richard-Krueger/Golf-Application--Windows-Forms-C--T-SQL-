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
    public partial class frmUserSelection : Form
    {
        public frmUserSelection()
        {
            InitializeComponent();
        }

        private void cboSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelection.SelectedIndex == 2)
            {
                Form addCourseForm = new frmCourse();
                addCourseForm.Show();
            }
            else if (cboSelection.SelectedIndex == 3)
            {
                Form editCourseForm = new frmCourse();
                editCourseForm.Show();
            }
            else if ((cboSelection.SelectedIndex == 5 || cboSelection.SelectedIndex == 6) /*&& CurrentUser.TeamType == 1*/)
            {
                Form roundForm = new frmWomenRound();
                roundForm.Show();
            }
            else if ((cboSelection.SelectedIndex == 5 || cboSelection.SelectedIndex == 6) /*&& CurrentUser.TeamType == 2*/)
            {
                Form roundForm = new frmMenRound();
                roundForm.Show();
            }
            else
            {
                cboSelection.Focus();
            }
        }
    }
}

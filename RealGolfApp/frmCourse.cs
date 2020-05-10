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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate inputs

            //Call stored procedure

            //Ask if user wishes to add another course

            //If yes, reset fields

            //If no, close form
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset fields
            var currentForm = new frmCourse();
            Clear.ClearAllBoxes(currentForm);            
        } 
    }
}

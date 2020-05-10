using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RealGolfApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSaveRegister_Click(object sender, EventArgs e)
        {
            byte[] userPassword;
            try
            {
                if (IsValidData())
                {
                    string userName = txtUserName.Text;
                    string uP = txtPassword1.Text;

                    UnicodeEncoding ue = new UnicodeEncoding();

                    byte[] messageBytes = ue.GetBytes(uP);

                    SHA256Managed shHash = new SHA256Managed();

                    userPassword = shHash.ComputeHash(messageBytes);

                    SQLConnection.RegisterUser(userName, Convert.ToString(userPassword));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unregisteredUsers._UnregisteredUsers' table. You can move, or remove it, as needed.
            this.unregisteredUsersTableAdapter.Fill(this.unregisteredUsers._UnregisteredUsers);
            txtUserName.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtUserName) &&
                !Validator.DoesContain(txtUserName) &&
                Validator.IsLength(txtUserName, 6, 25) &&

                Validator.IsPresent(txtPassword1) &&
                Validator.IsStrongPassword(txtPassword1) &&

                Validator.IsPresent(txtPassword2) &&
                Validator.IsStrongPassword(txtPassword2) &&
                Validator.IsMatch(txtPassword1, txtPassword2);
        }
    }
}

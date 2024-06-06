using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private CarRentalDBEntities1 credential;

        public Login()
        {
            InitializeComponent();
            credential = new CarRentalDBEntities1();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtuserName.Text.Trim();
            string password =  txtPassword.Text;
            var hashedPasswords = Utils.HashPassword(password);


            var entry = credential.Credentials.FirstOrDefault(cred =>
                cred.UserName == userName && cred.Password == hashedPasswords && cred.IsActive==true);
            if (entry == null)
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }
            else
            {
                var role = entry.UserRoleMappings.FirstOrDefault().Role;
                MainWindow mainWindow = new MainWindow(role.ID);
                mainWindow.Show();
                this.Hide();
            }
            
        }
    }
}

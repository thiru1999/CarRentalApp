using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddNewUser : Form
    {
        private readonly CarRentalDBEntities1 _db;
        public AddNewUser()
        {
            InitializeComponent();
            _db = new CarRentalDBEntities1();
        }


        private void AddNewUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.DisplayMember = "Name";
            cbRoles.ValueMember = "ID";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Credential
                {
                    UserName = txtUserName.Text,
                    Password = Utils.HashPassword("Password123"),
                    UserRoleMappings = new List<UserRoleMapping>
                    {
                        new UserRoleMapping
                        {
                            RoleId = (int) cbRoles.SelectedValue
                        }
                    }
                };
                _db.Credentials.Add(user);
                _db.SaveChanges();
                MessageBox.Show("User added successfully");
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An error occured: {exception.Message}");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

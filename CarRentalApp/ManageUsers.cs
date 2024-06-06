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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalDBEntities1 _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db=new CarRentalDBEntities1();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            var addNewUser = new AddNewUser();
            addNewUser.MdiParent = MdiParent;
            addNewUser.Show();
            addNewUser.FormClosed += LoadDataIntoGrid;

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var userId = int.Parse(gvManageUsers.SelectedRows[0].Cells["ID"].Value.ToString());
            var user = _db.Credentials.FirstOrDefault(q => q.ID == userId);
            string defaultNormalPassword = "Password123";
            string defaultHashedPassword = Utils.HashPassword(defaultNormalPassword);
            user.Password = defaultHashedPassword;
            _db.SaveChanges();
            MessageBox.Show($"{user.UserName}'s password resetted");


        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            var userId = (int)(gvManageUsers.SelectedRows[0].Cells["ID"].Value);
            var user = _db.Credentials.FirstOrDefault(q => q.ID == userId);
            user.IsActive = user.IsActive== true?false:true;
            _db.SaveChanges();
            MessageBox.Show($"{user.UserName}'s activation status changed");
            LoadDataIntoGrid(sender, e);
            

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            var users = _db.Credentials.Select
             (rec =>
                 new {
                     username = rec.UserName,
                     isActive = rec.IsActive,
                     ID = rec.ID

                 });
            gvManageUsers.DataSource = users.ToList();

        }

        private void LoadDataIntoGrid(object sender, EventArgs e)
        {
            var users = _db.Credentials.Select
             (rec =>
                 new {
                     username = rec.UserName,
                     isActive = rec.IsActive,
                     ID = rec.ID
                 }) ;
            gvManageUsers.DataSource = users.ToList();

        }

    }
}

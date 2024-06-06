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
    public partial class MainWindow : Form
    {
        private int _RoleId;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(int roleId)
        {
            InitializeComponent();
            _RoleId = roleId;
        }


        private void addCarRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var carRental = new AddCarRentalRecords();
            carRental.MdiParent = this;
            carRental.Show();
        }

        private void manageVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageVehicle = new ManageVehicle();
            manageVehicle.MdiParent = this;
            manageVehicle.Show();
        }

        private void manageCarRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRec= new Manage_Rental_Records();
            manageRentalRec.MdiParent = this;
            manageRentalRec.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var manageUser = new ManageUsers();
            manageUser.MdiParent = this;
            manageUser.Show();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(!(_RoleId == 1))
            {
                toolStripMenuManageuser.Visible = false;

            }
        }
    }
}

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
    public partial class Manage_Rental_Records : Form
    {
        private readonly CarRentalDBEntities1 _db;

        public Manage_Rental_Records()
        {
            InitializeComponent();
            _db = new CarRentalDBEntities1();
            btnEditRecord.Enabled = false;
            btnDeleteRecord.Enabled = false;
            gvManageRentalRecords.SelectionChanged += gvManageRentalRecords_SelectionChanged;
            
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            var addEditRecords = new AddCarRentalRecords();
            addEditRecords.MdiParent = MdiParent;
            addEditRecords.Show();
            addEditRecords.FormClosed += LoadDataIntoGrid;


        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            var customerRecID = int.Parse(gvManageRentalRecords.SelectedRows[0].Cells["custId"].Value.ToString());
            var record = _db.CarRentalRecords.FirstOrDefault(q => q.customerId == customerRecID);
            var addEditRecord = new AddCarRentalRecords(record);
            addEditRecord.MdiParent = MdiParent;
            addEditRecord.Show();
            addEditRecord.FormClosed += LoadDataIntoGrid;


        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            var customerRecID = int.Parse(gvManageRentalRecords.SelectedRows[0].Cells["custId"].Value.ToString());
            var record = _db.CarRentalRecords.FirstOrDefault(q => q.customerId == customerRecID);
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();
                LoadDataIntoGrid(sender, e);
            }

        }
        private void LoadDataIntoGrid(object sender, EventArgs e)
        {
            var rentalRecord = _db.CarRentalRecords.Select
                (rec =>
                    new {custId= rec.customerId,name=rec.CustomerName,cost=rec.RentCost,
                        vehicleout=rec.DateRented,vehiclein=rec.DateReturned,typeofCar=rec.TypeOfCarId});
            gvManageRentalRecords.DataSource = rentalRecord.ToList();
        }

        private void gvManageRentalRecords_SelectionChanged(object sender, EventArgs e)
        {
            btnEditRecord.Enabled = gvManageRentalRecords.SelectedRows.Count > 0;
            btnDeleteRecord.Enabled = gvManageRentalRecords.SelectedRows.Count > 0;

        }

        private void Manage_Rental_Records_Load(object sender, EventArgs e)
        {
            var rentalRecord = _db.CarRentalRecords.Select
            (rec =>
                new {
                    custId = rec.customerId,
                    name = rec.CustomerName,
                    cost = rec.RentCost,
                    vehicleout = rec.DateRented,
                    vehiclein = rec.DateReturned,
                    typeofCar = rec.TypeOfCarId
                });
            gvManageRentalRecords.DataSource = rentalRecord.ToList();

        }
    }
}

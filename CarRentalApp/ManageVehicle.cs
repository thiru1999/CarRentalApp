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
    public partial class ManageVehicle : Form
    {
        private readonly CarRentalDBEntities1 _db;
        public ManageVehicle()
        {
            InitializeComponent();
            _db = new CarRentalDBEntities1();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = MdiParent;
            addEditVehicle.Show();
            addEditVehicle.FormClosed += LoadDataIntoGrid;

        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            var carId = int.Parse(gvManageVehicle.SelectedRows[0].Cells["CarId"].Value.ToString());
            var car = _db.CarRecords.FirstOrDefault(q => q.CarId == carId);
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = MdiParent;
            addEditVehicle.Show();
            addEditVehicle.FormClosed += LoadDataIntoGrid;

        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            var carId = int.Parse(gvManageVehicle.SelectedRows[0].Cells["CarId"].Value.ToString());
            var car = _db.CarRecords.FirstOrDefault(q => q.CarId == carId);
            _db.CarRecords.Remove(car);
            _db.SaveChanges();
            LoadDataIntoGrid(sender, e);

        }
        private void LoadDataIntoGrid(object sender, EventArgs e)
        {
            var cars = _db.CarRecords.Select
                (rec => new { make = rec.Make, model = rec.Model, year = rec.Year, vin = rec.VIN, licenseNumber = rec.LicensePlateNumber, rec.CarId });
            gvManageVehicle.DataSource = cars.ToList();
        }

        private void ManageVehicle_Load(object sender, EventArgs e)
        {
            var cars = _db.CarRecords.Select
                (rec => new {  make  = rec.Make,model=rec.Model,year=rec.Year,vin=rec.VIN,licenseNumber=rec.LicensePlateNumber,rec.CarId });
            gvManageVehicle.DataSource = cars.ToList();
            gvManageVehicle.Columns[0].HeaderText="Make";
            gvManageVehicle.Columns[1].HeaderText = "Model";
            gvManageVehicle.Columns[2].HeaderText = "Year";
            gvManageVehicle.Columns[3].HeaderText = "VIN";
            gvManageVehicle.Columns[4].HeaderText = "LicenseNumber";

        }
    }
}

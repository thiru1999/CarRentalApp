using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditVehicle : Form
    {
        private bool isEditing = false;
        private readonly CarRentalDBEntities1 _db;
        private int carId;

        public AddEditVehicle()
        {
            InitializeComponent();
            lblAddEditVehicle.Text = "Add Vehicle";
            _db = new CarRentalDBEntities1();
            isEditing = false;
        }

        public AddEditVehicle(CarRecord carToEdit)
        {
            InitializeComponent();
            lblAddEditVehicle.Text = "Edit Vehicle";
            _db = new CarRentalDBEntities1();
            isEditing = true;
            PopulateFields(carToEdit);
        }

        private void PopulateFields(CarRecord car)
        {
            carId = car.CarId;
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtYear.Text = car.Year != null ?  car.Year.ToString() :"";
            txtVin.Text = car.VIN;
            txtLicenseNo.Text = car.LicensePlateNumber;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var car = _db.CarRecords.FirstOrDefault(rec => rec.CarId == carId);
                car.Make= txtMake.Text;
                car.Model = txtModel.Text;
                car.Year = txtYear.Text;
                car.VIN = txtVin.Text;
                car.LicensePlateNumber = txtLicenseNo.Text;
                _db.SaveChanges();

            }

            else
            {
                var car = new CarRecord
                {
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = txtYear.Text,
                    VIN = txtVin.Text,
                    LicensePlateNumber = txtLicenseNo.Text
                };
                _db.CarRecords.Add(car);
                _db.SaveChanges();

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

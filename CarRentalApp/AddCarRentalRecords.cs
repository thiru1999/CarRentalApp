using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRentalApp.BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentalApp
{
    public partial class AddCarRentalRecords : Form
    {
        private readonly CarRentalDBEntities1 carRentalDbEntities1;
        internal EventHandler<FormData> BlEventHandler;
        internal FormData frmData;
        private bool isEditing = false;
        private int customerRecId;
        private CarRentalRecord carRentalRecordtoEdit;

        public AddCarRentalRecords()
        {
            InitializeComponent();
            carRentalDbEntities1 = new CarRentalDBEntities1();
            isEditing = false;
        }
        public AddCarRentalRecords(CarRentalRecord rec)
        {
            InitializeComponent();
            carRentalDbEntities1 = new CarRentalDBEntities1();
            isEditing = true;
            carRentalRecordtoEdit=rec;
            PopulateFields(rec);
        }

        private void PopulateFields(CarRentalRecord rec)
        {
            customerRecId = rec.customerId;
            txtCustomerName.Text = rec.CustomerName;
            txtCost.Text = rec.RentCost.ToString();
            pickerIn.Value = (DateTime)rec.DateRented;
            pickerOut.Value = (DateTime)rec.DateReturned;
            cmbTypeOfCar.SelectedValue = (int)rec.TypeOfCarId;
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmData = new FormData(txtCustomerName.Text, txtCost.Text, pickerIn.Value, pickerOut.Value,
                cmbTypeOfCar.Text);
            BusinessLogic bl = new BusinessLogic();
            bl.ValidationOverEventHandler += FeedbackShow;
            BlEventHandler += bl.HandleSubmitButtonClick;
            BlEventHandler?.Invoke(this, frmData);
        }

        internal void FeedbackShow(object sender, ValidationOverEventArgs e)
        {
            if (! e.IsValid)
            {
                MessageBox.Show(e.ErrorMessage);
            }
            else
            {
                if (isEditing)
                {
                    var id = customerRecId;
                    carRentalRecordtoEdit = carRentalDbEntities1.CarRentalRecords.FirstOrDefault(q => q.customerId == id);
                    carRentalRecordtoEdit.CustomerName = frmData.CustomerName;
                    carRentalRecordtoEdit.RentCost = Convert.ToDecimal(frmData.Cost);
                    carRentalRecordtoEdit.DateRented = frmData.DateRented;
                    carRentalRecordtoEdit.DateReturned = frmData.DateReturned;
                    carRentalRecordtoEdit.TypeOfCarId = Convert.ToInt32(cmbTypeOfCar.SelectedValue);
                    carRentalDbEntities1.SaveChanges();
                    MessageBox.Show("Entry Edited Successfully ");


                }
                else
                {
                    var carRentalRecords = new CarRentalRecord();
                    carRentalRecords.CustomerName = frmData.CustomerName;
                    carRentalRecords.RentCost = Convert.ToDecimal(frmData.Cost);
                    carRentalRecords.DateRented = frmData.DateRented;
                    carRentalRecords.DateReturned = frmData.DateReturned;
                    carRentalRecords.TypeOfCarId = Convert.ToInt32(cmbTypeOfCar.SelectedValue);

                    carRentalDbEntities1.CarRentalRecords.Add(carRentalRecords);
                    carRentalDbEntities1.SaveChanges();
                    MessageBox.Show("Thanks For Having Business With Us ");


                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalDbEntities1.CarRecords.Select
                (rec => new { carId = rec.CarId, name = rec.Make+rec.Model }).ToList();
            cmbTypeOfCar.DisplayMember = "name";
            cmbTypeOfCar.ValueMember = "CarId";
            cmbTypeOfCar.DataSource = cars;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}

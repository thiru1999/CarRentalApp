using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    internal class FormData:EventArgs{
        internal string CustomerName { get; set; }
        internal string Cost { get; set; }
        internal DateTime DateRented { get; set; }

        internal DateTime DateReturned { get; set; }
        internal string TypeOfCar { get; set; }

        public FormData(string customername,string cost, DateTime dateRented, DateTime dateReturned,string typeOfCar)
        {
            CustomerName = customername;
            Cost = cost;    
            DateRented = dateRented;
            DateReturned = dateReturned;
            TypeOfCar = typeOfCar;
        }
        
    }
}

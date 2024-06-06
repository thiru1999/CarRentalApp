using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    internal class BusinessLogic
    {
        public EventHandler<ValidationOverEventArgs> ValidationOverEventHandler;
        public void HandleSubmitButtonClick(object sender, FormData e)
        {
            bool isValid = true;
            string errorMessage = string.Empty;
            InputDataValidation(ref isValid,e,ref errorMessage);
            DateValidation(ref isValid, e, ref errorMessage);
            var validationOverEventArgs = new ValidationOverEventArgs(isValid, errorMessage);
            ValidationOverEventHandler?.Invoke(this, validationOverEventArgs);

        }

        private void InputDataValidation( ref bool isValid,FormData frm,ref string errorMessage)
        {
            
                if (string.IsNullOrWhiteSpace(frm.CustomerName) || string.IsNullOrWhiteSpace(frm.TypeOfCar))
                {
                    isValid = false;
                    errorMessage += "Enter Missing Data ";
                }
        }


        private void DateValidation(ref bool isValid, FormData frm, ref string errorMessage)
        {
            if (frm.DateRented > frm.DateReturned)
            {
                isValid = false;
                errorMessage += "Invalid Date";
            }
        }

        public class ValidationOverEventArgs : EventArgs
        {
            internal bool IsValid { get; set; }
            internal string ErrorMessage { get; set; }

            public ValidationOverEventArgs(bool isValid, string errorMessage)
            {
                IsValid = isValid;
                ErrorMessage = errorMessage;
            }
        }
    }
}

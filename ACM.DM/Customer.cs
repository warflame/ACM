using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.DM
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }

        public string FullName {

            get {

                string fullName = FirstName;
                if (!string.IsNullOrEmpty(fullName))
                {
                    if (!string.IsNullOrEmpty(LastName))
                    {
                        fullName += " " + LastName;
                    }
                    else
                    {
                        fullName += LastName;
                    }
                }
                else
                {
                    fullName += LastName;
                }
                return fullName;
            }
        }

        public bool ValidateInputs() {

            bool isValid = true;
            if(string.IsNullOrEmpty(FirstName))isValid=false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}

using ACM.DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.REP
{
    public class CustomerRepository
    {
        public Customer retriveData(int customerId){

            Customer customer = new Customer(customerId);

            customer.FirstName = "Tharindu";
            customer.LastName = "Dassanayake";
            customer.EmailAddress = "Tharindud@masholdings.com";

            return customer;

        }
        public Customer saveData()
        {
            return new Customer();
        }
    }
}

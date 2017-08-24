using ACM.DM;
using ACM.DM.Entities;
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

            //Customer customer = new Customer(customerId);
            //customer.FirstName = "Tharindu";
            //customer.LastName = "Dassanayake";
            //customer.EmailAddress = "Tharindud@masholdings.com";
            using (var ctx = new ACMEntities())
            {
                return ctx.Customers.Where(x=>x.Id==customerId).FirstOrDefault();
            }

        }
        public Customer saveData()
        {
            return new Customer();
        }
    }
}

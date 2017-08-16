using ACM.DM;
using ACM.REP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerBL
    {
        
        public Customer retriveData(int customerId) {
            CustomerRepository customerRepository = new CustomerRepository();
         return   customerRepository.retriveData(customerId);
        }

    }
}

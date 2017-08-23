using ACM.DM;
using ACM.REP;
using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Common.Interfaces;


namespace ACM.BL
{
    public class CustomerBL : ICommonControls
    {
        
        public Customer retriveData(int customerId) {
            CustomerRepository customerRepository = new CustomerRepository();
         return   customerRepository.retriveData(customerId);
        }

        public string removeSpaceInString(string val) {
            return val.SpaceRemove();
        }

        public bool ValidateString(string val)
        {
            throw new NotImplementedException();
        }
    }
}

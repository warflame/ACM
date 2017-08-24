using ACM.DM;
using ACM.REP;
using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Common.Interfaces;
using ACM.DM.Entities;
using ACM.DM.DTO;
using ACM.BL.Mappers;
using ACM.BL.Interfaces;


namespace ACM.BL
{
    public class CustomerBL : ICutomerBL
    {
        private readonly MapperBase<Customer, CustomerDto> custMapper = new CustomerDtoMapper();    



        public Customer retriveData(int customerId) {
            CustomerRepository customerRepository = new CustomerRepository();
         return   customerRepository.retriveData(customerId);
        }

        public string removeSpaceInString(string val) {
            return val.SpaceRemove();
        }

        public bool ValidateString(string val)
        {
            var cust = new ACM.DM.Entities.Customer
            {
                Id = 1,
                FirstName = "Tharindu",
                LastName = "Dassa",
                EmailAddress = "Tharibaba@mas.com"
            };

            var custdto = new CustomerDto();
            //var tt = new MapperBase<Customer, CustomerDto>().map(custdto, cust);
            var tt = custMapper.map(custdto, cust);
            return tt.FirstName.Equals(cust.FirstName);
        }
    }
}

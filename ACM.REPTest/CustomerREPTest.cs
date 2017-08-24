using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.REP;
using ACM.DM;
using ACM.DM.Entities;

namespace ACM.REPTest
{
    [TestClass]
    public class CustomerREPTest
    {
        [TestMethod]
        public void RetriveDataTest()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            

            Customer expected = new Customer(1);

            expected.FirstName = "Tharindu";
            expected.LastName = "Dassanayake";
            expected.EmailAddress = "Tharindud@masholdings.com";

            Customer actual = new Customer(1);
            actual = customerRepository.retriveData(1);

            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

        }
    }
}

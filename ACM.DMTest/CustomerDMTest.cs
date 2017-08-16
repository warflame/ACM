using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.DM;

namespace ACM.DMTest
{
    [TestClass]
    public class CustomerDMTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tharindu1";
            customer.LastName = "Dassanayake";

            string expected = "Tharindu Dassanayake";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameWithoutFirstNameTest()
        {
            Customer customer = new Customer();
            customer.LastName = "Dassanayake";

            string expected = "Dassanayake";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameWithoutLastNameTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tharindu";

            string expected = "Tharindu";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerIdTest()
        {
            Customer customer = new Customer();
            //customer.CustomerId =1;

            int expected = 0;

            int actual =customer.CustomerId;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateInputValidValuesTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tharindu";
            customer.EmailAddress = "TharinduDassanayake@gmail.com";

            bool expected = true;

            bool actual = customer.ValidateInputs();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInputInvalidValuesTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tharindu";
            //customer.EmailAddress = "TharinduDassanayakegmail.com               ";

            bool expected = false;

            bool actual = customer.ValidateInputs();

            Assert.AreEqual(expected, actual);
        }
    }
}

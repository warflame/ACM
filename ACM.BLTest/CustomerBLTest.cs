using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using ACM.Common;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerBLTest
    {

        [TestMethod]
        public void SpaceRemoveTest()
        {
            var customerBL=new CustomerBL();
            var passString="Tharindu Dassanayake";

            string expected = "TharinduDassanayake";

            string actual = customerBL.removeSpaceInString(passString);

            Assert.AreEqual(expected, actual);
        }
        
    }
}

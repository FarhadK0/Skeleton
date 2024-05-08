using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // test to see that it exits
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Name";
            //assign the data to the property
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Email";
            //assign the data to the property
            AnCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerPhoneOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Phone";
            //assign the data to the property
            AnCustomer.CustomerPhone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPhone, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Address";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void DateofbirthOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.Dateofbirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Dateofbirth, TestData);
        }
        [TestMethod]
        public void hasPurchases()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.hasPurchases = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.hasPurchases, TestData);
        }
    }
}

    


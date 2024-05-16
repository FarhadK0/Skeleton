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
        [TestMethod]
        public void FindMethodOK()
        {
            //class an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Blooean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            // test to see if the results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //class an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Blooean variable to store the result of the search
            Boolean Found = false;
            //create a Blooean variable to record if the data is ok(assume it is)
            Boolean OK = true;
            // create some test data to use the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer id
            if (AnCustomer.CustomerID !=1)
            {
                OK = false;
            }
            //tets to see that the results is correct
            Assert.IsTrue(OK); 
        }

        [TestMethod]
        public void TestDateofbirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the date added property
            if (AnCustomer.Dateofbirth!= Convert.ToDateTime("03/05/2002"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the house no property
            if (AnCustomer.CustomerName != "Jainish")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the street property
            if (AnCustomer.CustomerEmail != "Jainish@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPhoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID= 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the town property
            if (AnCustomer.CustomerPhone != "0099887766")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the post code property
            if (AnCustomer.CustomerAddress != "1234 Leicster ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TesthasPurchasesFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the active property
            if (AnCustomer.hasPurchases != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
    


    


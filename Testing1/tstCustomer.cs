using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        // good test data
        // create some test data to pass the method
        string CustomerName = "Jainish";
        string CustomerEmail = "Jainish@gmail.com";
        string CustomerPhone = "0099887766";
        string CustomerAddress = "1234 Leicster";
        string Dateofbirth = Convert.ToString("25/02/1988");

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
            string TestData = "Name";
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
            if (AnCustomer.CustomerID != 1)
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
            if (AnCustomer.Dateofbirth != Convert.ToDateTime("03/05/2002"))
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
            Int32 CustomerID = 1;
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
            if (AnCustomer.CustomerAddress != "1234 Leicester")
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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessone()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "J";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "JJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "JJJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "JJJJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "JJJJJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(100, 'J');// this should fail
            //Invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinLessone()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "J";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "JJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "JJJJJJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "JJJJJJJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = new string('J', 51);
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string CustomerEmail = "JJJJ";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinMinusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = ""; // Blank address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinBoundary()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = "J"; // Single character address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = "JD"; // Two characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxMinusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = new string('J', 74); // 74 characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxBoundary()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = new string('J', 75); // 75 characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = new string('J', 76); // 76 characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = new string('J', 38); // 38 characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = new string('J', 200); // 200 characters address
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressInvalidDataType()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to the method
            string CustomerAddress = ""; // Invalid data type
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneMid()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerPhone = "";
            CustomerPhone = CustomerPhone.PadRight(9, '2');
            // Test data: 9 characters phone number
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreEqual(Error, "");  // 9 characters phone number should fail according to your specification
        }

        [TestMethod]
        public void CustomerPhoneMinLessOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: blank phone number
            string CustomerPhone = "";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMin()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 1 character phone number
            string CustomerPhone = "1";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 2 characters phone number
            string CustomerPhone = "12";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 17 characters phone number
            string CustomerPhone = "12345678901234567";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMax()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 18 characters phone number
            string CustomerPhone = "123456789012345678";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 19 characters phone number
            string CustomerPhone = "1234567890123456789";
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneExtremeMax()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Test data: 50 characters phone number
            string CustomerPhone = new string('1', 50);
            // Invoke the validation method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Check if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateofbirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestData;
            //set the date totodays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestData = TestData.AddYears(-1);
            //convert the date variable to a string variable
            string Dateofbirth = TestData.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofbirthMin()
        {
            // Create an instance of the class we want to test
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            // Create some test data to pass to method
            DateTime testData = DateTime.Now.Date.AddYears(-18);
            string Dateofbirth = testData.ToString(); // This would be the date 18 years ago

            // Invoke the Valid method
             Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateofbirthMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestData;
            // Set the date to today's date
            TestData = DateTime.Now.Date;
            // Change the date to whatever the date is minus 1 day
            TestData = TestData.AddYears(-19); // Adjusted to be one day more than 18 years ago
                                                          // Convert the date variable to a string variable
            string Dateofbirth = TestData.ToString();
            // Invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofbirthInvalidDataType()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to method
            string Dateofbirth = "invalid date"; // invalid date type
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerPhone, CustomerAddress, Dateofbirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
    }

}
 






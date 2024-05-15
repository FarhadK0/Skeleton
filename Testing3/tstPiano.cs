using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;

namespace Testing3
{
    [TestClass]
    public class tstPiano
    {
        //"good" test data to pass the method
        string DateAdded = DateTime.Now.ToShortDateString();
        string Price = "399.99";
        string Manufacturer = "Roland";
        string ModelName = "Electric Piano";
        string SerialNumber = "1234567890";
        //bool values are currently not being tested

        /***INSTANCE TESTS***/
        [TestMethod]
        public void InstanceOK()
        {
            // create a new instance of Piano
            clsPiano aPiano = new clsPiano();
            // test if it exists
            Assert.IsNotNull(aPiano);
        }

        /***ATTRIBUTE OK TESTS***/
        [TestMethod]
        public void PianoIdOK()
        {
            //new instance of Piano
            clsPiano aPiano = new clsPiano();
            //test data
            Int32 testPianoId = 1;
            //assign data to pianoId
            aPiano.PianoId = testPianoId;
            //test
            Assert.AreEqual(aPiano.PianoId, testPianoId);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            DateTime testDateAdded = DateTime.Now.Date;
            //assign data to aDateAdded
            aPiano.DateAdded = testDateAdded;
            //test
            Assert.AreEqual(aPiano.DateAdded, testDateAdded);
        }

        [TestMethod]
        public void PriceOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            double testPrice = 123.99;
            //assign data to aDateAdded
            aPiano.Price = testPrice;
            //test
            Assert.AreEqual(aPiano.Price, testPrice);
        }

        [TestMethod]
        public void ManufacturerOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            string testManufacturer = "Yamaha";
            //assign data to aDateAdded
            aPiano.Manufacturer = testManufacturer;
            //test
            Assert.AreEqual(aPiano.Manufacturer, testManufacturer);
        }

        [TestMethod]
        public void ModelNameOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            string testModelName = "Upright B1";
            //assign data to aDateAdded
            aPiano.ModelName = testModelName;
            //test
            Assert.AreEqual(aPiano.ModelName, testModelName);
        }

        [TestMethod]
        public void IsInStockOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            Boolean testIsInStock = true;
            //assign data to aDateAdded
            aPiano.IsInStock = testIsInStock;
            //test
            Assert.AreEqual(aPiano.IsInStock, testIsInStock);
        }

        [TestMethod]
        public void SerialNumberOK()
        {
            //new instance of piano
            clsPiano aPiano = new clsPiano();
            //test data
            string testSerialNumber = "987435098743";
            //assign data to aDateAdded
            aPiano.SerialNumber = testSerialNumber;
            //test
            Assert.AreEqual(aPiano.SerialNumber, testSerialNumber);
        }

        /***FIND METHOD TEST***/
        [TestMethod]
        public void FindOK()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        /***ATTRIBUTE DATA TESTS***/
        [TestMethod]
        public void TestPianoIdFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.PianoId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.DateAdded != Convert.ToDateTime("12/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.Price != 399.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManufacturerFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.Manufacturer != "Kawai")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelNameFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.ModelName != "GX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsInStockFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.IsInStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSerialNumberFound()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PianoId = 2;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.SerialNumber != "00231")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /***VALID METHOD TEST***/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the piano class
            clsPiano aPiano = new clsPiano();
            //var to store any error message
            String Error = "";
            //invoke method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Check that the results are correct
            Assert.AreEqual(Error, "");
        }

        /***ATTIBUTE VALIDATION TESTS***/
        [TestMethod]
        public void ManufacturerMinMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMin()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "*";
            //Manufacturer.PadRight(1, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMinPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "**";
            //Manufacturer.PadRight(2, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMaxMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "*******************";
            //Manufacturer.PadRight(19, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "********************";
            //Manufacturer.PadRight(20, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMaxPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "";
            Manufacturer.PadRight(21, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerMid()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "**********";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerExtremeMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string Manufacturer = "";
            Manufacturer.PadRight(50, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMinMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMin()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "*";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMinPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "**";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMaxMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "*******************";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "********************";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMaxPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "";
            ModelName.PadRight(21, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameMid()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "**********";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNameExtremeMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string ModelName = "";
            ModelName.PadRight(50, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMinMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMin()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "*";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMinPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "**";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMaxMinusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "*******************";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "********************";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMaxPlusOne()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "";
            SerialNumber.PadRight(21, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SerialNumberMid()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "**********";
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void serialNumberExtremeMax()
        {
            //create a piano instance
            clsPiano aPiano = new clsPiano();
            //variable for storing errors
            String Error = "";
            //target test data
            string SerialNumber = "";
            SerialNumber.PadRight(50, '*');
            //Run validation method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //Test if desired result is achieved
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinMinusOne()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidDate()
        {
            //create an instance of the class we want to create
            clsPiano aPiano = new clsPiano();
            //string variable to store any error message
            String Error = "";
            // wrong data type
            string DateAdded = "this is not a date!";
            Error = aPiano.Valid(DateAdded, Price, Manufacturer, ModelName, SerialNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

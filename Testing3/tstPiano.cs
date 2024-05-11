﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Security.Cryptography;

namespace Testing3
{
    [TestClass]
    public class tstPiano
    {
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
            Int32 PianoId = 1;
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
            Int32 PianoId = 1;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.PianoId != 1)
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
            Int32 PianoId = 1;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.DateAdded != Convert.ToDateTime("12/05/2024"))
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
            Int32 PianoId = 1;
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
            Int32 PianoId = 1;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.Manufacturer != "Yamaha")
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
            Int32 PianoId = 1;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.ModelName != "Upright B1")
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
            Int32 PianoId = 1;
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
            Int32 PianoId = 1;
            //invoke the method
            Found = aPiano.Find(PianoId);
            //check the address id property
            if (aPiano.SerialNumber != "928719308")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstPiano
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create a new instance of Piano
            clsPiano aPiano = new clsPiano();
            // test if it exists
            Assert.IsNotNull(aPiano);
        }

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
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstPianoCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //test if it exists
            Assert.IsNotNull(allPianos);
        }

        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //create some test data needs to be a list of objects
            //list of objects
            List<clsPiano> TestList = new List<clsPiano>();

            //add a new item for the list
            clsPiano TestItem = new clsPiano();
            //set its properties
            TestItem.PianoId = 21;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 499.99;
            TestItem.Manufacturer = "Bosendorf";
            TestItem.ModelName = "Grand Piano";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "s38-9fug-98";
            //add the item to the list
            TestList.Add(TestItem);

            //assign the data to the property
            allPianos.PianoList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allPianos.PianoList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            allPianos.Count = SomeCount;
            //test
            Assert.AreEqual(allPianos.Count, SomeCount);
        }

        [TestMethod]
        public void ThisPianoPropertyOK()
        {
            //create an instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //create an instance of a piano
            clsPiano TestItem = new clsPiano();
            //set its properties
            TestItem.PianoId = 21;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 499.99;
            TestItem.Manufacturer = "Bosendorf";
            TestItem.ModelName = "Grand Piano";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "s38-9fug-98";
            //assign the data to the property
            allPianos.ThisPiano = TestItem;
            //test
            Assert.AreEqual(allPianos.ThisPiano, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //create some test data needs to be a list of objects
            //list of objects
            List<clsPiano> TestList = new List<clsPiano>();

            //add a new item for the list
            clsPiano TestItem = new clsPiano();
            //set its properties
            TestItem.PianoId = 21;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 499.99;
            TestItem.Manufacturer = "Bosendorf";
            TestItem.ModelName = "Grand Piano";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "s38-9fug-98";
            //add the item to the list
            TestList.Add(TestItem);

            //assign the data to the property
            allPianos.PianoList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allPianos.Count, TestList.Count);
        }
    }
}

﻿using ClassLibrary;
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

        /*
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of allPianos
            clsPianoCollection allPianos = new clsPianoCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            allPianos.Count = SomeCount;
            //test
            Assert.AreEqual(allPianos.Count, SomeCount);
        }
        */

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

        /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsPianoCollection allPianos = new clsPianoCollection();
            //test to see if there are two records
            Assert.AreEqual(allPianos.Count, 2);
        }
        */

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of piano collection
            clsPianoCollection allPianos = new clsPianoCollection();
            //create the test item
            clsPiano TestItem = new clsPiano();
            //var to store PK
            Int32 PK = 0;

            //set TestItem properties
            TestItem.PianoId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 999.99;
            TestItem.Manufacturer = "Steinway";
            TestItem.ModelName = "GG-1";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "dfh98";
            
            //set ThisPiano to test data
            allPianos.ThisPiano = TestItem;
            //add the record
            PK = allPianos.Add();
            //set the PK of the test data
            TestItem.PianoId = PK;
            //find the record
            allPianos.ThisPiano.Find(PK);
            //test to see that the two values are the same
            Assert.AreEqual(allPianos.ThisPiano, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of piano collection
            clsPianoCollection allPianos = new clsPianoCollection();
            //create the test item
            clsPiano TestItem = new clsPiano();
            //var to store PK
            Int32 PK = 0;

            //set TestItem properties
            TestItem.PianoId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 999.99;
            TestItem.Manufacturer = "Roland";
            TestItem.ModelName = "A Nice Piano";
            TestItem.IsInStock = true;
            TestItem.SerialNumber = "dfh9sdad";

            //set ThisPiano to test data
            allPianos.ThisPiano = TestItem;
            //add the record
            PK = allPianos.Add();
            //set the PK of the test data
            TestItem.PianoId = PK;

            //modify TestItem properties
            TestItem.PianoId = 9;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 999.98;
            TestItem.Manufacturer = "Roland";
            TestItem.ModelName = "Not A Nice Piano";
            TestItem.IsInStock = false;
            TestItem.SerialNumber = "dasdad";

            //set ThisPiano to new test data
            allPianos.ThisPiano = TestItem;
            //update the record
            allPianos.Update();
            //find the record
            allPianos.ThisPiano.Find(PK);
            //test to see if ThisPiano matches the test data
            Assert.AreEqual(allPianos.ThisPiano, TestItem);
        }
    }
}

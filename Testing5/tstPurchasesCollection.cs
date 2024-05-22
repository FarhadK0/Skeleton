using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstPurchasesCollection
    {
        [TestMethod]
        public void PurchaseListOK()
        {
            //Instance class of the class we wanted to create
            clsPurchasesCollection AllPurchases = new clsPurchasesCollection();
            
            //Create some test data to assign to property (Data needs to be a list of objects
            List <clsPurchases> TestList = new List<clsPurchases> ();   

            //Add an item to the list (Create the item of test data)
            clsPurchases TestItem = new clsPurchases();

            //Properties being set
            TestItem.PurchaseId = 1;
            TestItem.CustomerName = "Chloe Hans";
            TestItem.DeliveryOptions = "Morning";
            TestItem.ProductPrice = 1.99;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 1.99;
            TestItem.OrderConfirmed = true;

            //Add the test to the test list
            TestList.Add(TestItem);

            //Assign the data to the property
            AllPurchases.PurchaseList = TestList;

            //Test to see that he two values are the same
            Assert.AreEqual(AllPurchases.PurchaseList, TestList);
            
        }

        [TestMethod]
        public void InstanceOK()
        {
            //Instance class of the class we wanted to create
            clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

            //Test to see if it exists
            Assert.IsNotNull(AllPurchases);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Instance class of the class we wanted to create
            clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

            //Create some test data to assign to the property (Data = List Of Objects)
            List<clsPurchases> TestList = new List<clsPurchases>();

            //Add an item to the list & create the item of test data
            clsPurchases TestItem = new clsPurchases();

            //Properties being set
            TestItem.PurchaseId = 1;
            TestItem.CustomerName = "Chloe Hans";
            TestItem.DeliveryOptions = "Morning";
            TestItem.ProductPrice = 1.99;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 1.99;
            TestItem.OrderConfirmed = true;

            //Adding the test to the test list
            TestList.Add(TestItem);

            //Data assigned to property
            AllPurchases.PurchaseList = (TestList);

            //Test to see that the two values are the same
            Assert.AreEqual(AllPurchases.PurchaseList, TestList);
        }

        [TestMethod]
        public void ThisPurchasePropertyOK()
        {
            //Instance class of the class we wanted to create
            clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

            //Add an item to the list & create the item of test data
            clsPurchases TestPurchase = new clsPurchases();

            //Properties being set
            TestPurchase.PurchaseId = 1;
            TestPurchase.CustomerName = "Chloe Hans";
            TestPurchase.DeliveryOptions = "Morning";
            TestPurchase.ProductPrice = 1.99;
            TestPurchase.Quantity = 1;
            TestPurchase.OrderDate = DateTime.Now;
            TestPurchase.TotalAmount = 1.99;
            TestPurchase.OrderConfirmed = true;

            //Assign date to the property
            AllPurchases.ThisPurchase = TestPurchase;

            //Test to see that two values are the same
            Assert.AreEqual(AllPurchases.ThisPurchase, TestPurchase);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Instance class of the class we wanted to create
            clsPurchasesCollection AllPurchases = new clsPurchasesCollection();

            //Add an item to the list & create the item of test data
            clsPurchases TestItem = new clsPurchases();

            //Variable to store Primary Key
            Int32 PrimaryKey = 0;

            //Properties being set
            TestItem.PurchaseId = 1;
            TestItem.CustomerName = "Chloe Hans";
            TestItem.DeliveryOptions = "Morning";
            TestItem.ProductPrice = 1.99;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 1.99;
            TestItem.OrderConfirmed = true;

            //Set ThisPurchase to the test data
            AllPurchases.ThisPurchase = TestItem;

            //Record added
            PrimaryKey = AllPurchases.Add();

            //Primary key of the test data being set
            TestItem.PurchaseId = PrimaryKey;

            //Record being looked for
            AllPurchases.ThisPurchase.Find(PrimaryKey);

            //Test to see if two values are same
            Assert.AreEqual(AllPurchases.ThisPurchase, TestItem);

        }
    }
}


using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void IntanceOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            // testto see that is exits
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create some test data to assign to the property 
            // in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            // Add an Item to the List
            // create the item of the data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.hasPurchases = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jainish";
            TestItem.CustomerEmail = "Jainish@gmail.com";
            TestItem.Dateofbirth = DateTime.Now.Date;
            TestItem.CustomerPhone = "0099887766";
            TestItem.CustomerAddress = "1234 Leicster ";
            //add the tiem to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllCustomers.CustomerList, TestList);



        }
       /* [TestMethod]
        public void CountOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            // assign the data to proprty
            AllCustomers.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
       */
        [TestMethod]
        public void ThisCustomerOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.hasPurchases = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Jainish";
            TestCustomer.CustomerEmail = "Jainish@gmail.com";
            TestCustomer.Dateofbirth = DateTime.Now.Date;
            TestCustomer.CustomerPhone = "0099887766";
            TestCustomer.CustomerAddress = "1234 Leicster ";
            //assign the data to the proprty
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create some test data to assign to property
            // in this case the data needs to be a lits of object
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item of test data 
            //create the Item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.hasPurchases = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jainish";
            TestItem.CustomerEmail = "Jainish@gmail.com";
            TestItem.Dateofbirth = DateTime.Now.Date;
            TestItem.CustomerPhone = "0099887766";
            TestItem.CustomerAddress = "1234 Leicster ";
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that the two values are the dsame
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}       /* [TestMethod]
        public void TwoRecordsPresent()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);

        }
    }
}
   */

    

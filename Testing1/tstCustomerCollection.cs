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
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // testto see that is exits
            Assert.IsNotNull(AllCustomers);
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

            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jainish";
            TestItem.CustomerEmail = "Jainish@gmail.com";
            TestItem.CustomerPhone = "0099887766";
            TestItem.CustomerAddress = "1234 Leicster";
            TestItem.Dateofbirth = Convert.ToDateTime("03/05/2002");
            TestItem.hasPurchases = true;
            //add the tiem to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
            

        [TestMethod]
        public void ThisCustomerOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Jainish";
            TestCustomer.CustomerEmail = "Jainish@gmail.com";
            TestCustomer.CustomerPhone = "0099887766";
            TestCustomer.CustomerAddress = "1234 Leicster";
            TestCustomer.Dateofbirth = Convert.ToDateTime("03/05/2002"); 
            TestCustomer.hasPurchases = true;
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
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jainish";
            TestItem.CustomerEmail = "Jainish@gmail.com";
            TestItem.CustomerPhone = "0099887766";
            TestItem.CustomerAddress = "1234 Leicster";
            TestItem.Dateofbirth = Convert.ToDateTime("03/05/2002");
            TestItem.hasPurchases = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that the two values are the dsame
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the Item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Add method Customer";
            TestItem.CustomerEmail = "CustomerEmail";
            TestItem.CustomerPhone = "0099887700";
            TestItem.Dateofbirth = Convert.ToDateTime("07/05/2001");
            TestItem.CustomerAddress = "12346 Leicster";
            TestItem.hasPurchases = true;
            // set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //Find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that  the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the Item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Pablo";
            TestItem.CustomerEmail = "Pablo@gmail.com";
            TestItem.CustomerPhone = "0099886666";
            TestItem.Dateofbirth = Convert.ToDateTime("10/10/2000");
            TestItem.CustomerAddress = "14 Leicster";
            TestItem.hasPurchases = true;
            // set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            // MODIFY THE TEST RECORD
            TestItem.CustomerID = 3;
            TestItem.CustomerName = "Iphone";
            TestItem.CustomerEmail = "Iphone@gmail.com";
            TestItem.CustomerPhone = "9944556677";
            TestItem.Dateofbirth = Convert.ToDateTime("24/12/1999");
            TestItem.CustomerAddress = "67 Leicester";
            TestItem.hasPurchases = true;
            //SET THE Record based  on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that  the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the Item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Ronaldo";
            TestItem.CustomerEmail = "Ronaldo@gmail.com";
            TestItem.CustomerPhone = "0006661290";
            TestItem.Dateofbirth = Convert.ToDateTime("20/11/2004");
            TestItem.CustomerAddress = "38 Leicster";
            TestItem.hasPurchases = true;
            // set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //Find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that  the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerEmailMethodOK()
        {
            //create an intance of the class containingunfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all rrecord);
            FilteredCustomers.ReportByCustomerEmail("");
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByCustomerEmailNoneFound() 
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a CustomerEmail that doesn't exit
            FilteredCustomers.ReportByCustomerEmail("xxx@xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
           
        }
        [TestMethod]
        public void ReportByCustomerEmailTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            // applay a customer Email that doesn't exits
            FilteredCustomers.ReportByCustomerEmail("Josh@gmail.com");
            // check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredCustomers.CustomerList[0].CustomerID != 66)
                {
                    OK = false;
                }
                //check to see that the first record is 25
                if (FilteredCustomers.CustomerList[1].CustomerID != 68)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record 
            Assert.IsTrue(OK);
        }

    }
}

        

    

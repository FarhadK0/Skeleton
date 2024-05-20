using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Testing2
{
    [TestClass]
    public class tstCustomerSupportCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerSupportCollection AllCustomerSupports = new clsCustomerSupportCollection ();

            //test to see that is exists
            Assert.IsNotNull (AllCustomerSupports);
        }

        [TestMethod]

        public void CustomerSupportListOK()
        {
            //create an insatance of the class we want to create 
            clsCustomerSupportCollection AllCutsomerSupports = new clsCustomerSupportCollection ();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomerSupport> TestList = new List<clsCustomerSupport> ();

            //Add an Item of the list
            //create the item of test data
            clsCustomerSupport TestItem = new clsCustomerSupport();

            //set its properties
            TestItem.TicketID = 1;
            TestItem.TicketType = "Technical Support";
            TestItem.Subject = "reset password";
            TestItem.Description = "cannot reset the password";
            TestItem.SubmissionDate = DateTime.Now;
            TestItem.TicketStatus = "InProgress";
            TestItem.TicketElevated = true;

            //add the item to the test list
            TestList.Add (TestItem);

            //assign the data to the property
            AllCutsomerSupports.CustomerSupportList = TestList;

            //test to see that two values are the same
            Assert.AreEqual(AllCutsomerSupports.CustomerSupportList, TestList);
        }

       

        [TestMethod]

        public void ThisCustomerSupportPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerSupportCollection AllCustomerSupports = new clsCustomerSupportCollection();

            //create some test data to assign to the property
            clsCustomerSupport TestCustomerSupport = new clsCustomerSupport();

            //set the properties of the test object
            TestCustomerSupport.TicketID = 1;
            TestCustomerSupport.TicketType = "Technical Support";
            TestCustomerSupport.Subject = "reset password";
            TestCustomerSupport.Description = "cannot reset the password";
            TestCustomerSupport.SubmissionDate = DateTime.Now;
            TestCustomerSupport.TicketStatus = "InProgress";
            TestCustomerSupport.TicketElevated= true;

            //assign the data to the property
            AllCustomerSupports.ThisCustomerSupport = TestCustomerSupport;

            //test to see that two values are the same
            Assert.AreEqual(AllCustomerSupports.ThisCustomerSupport, TestCustomerSupport);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerSupportCollection AllCustomerSupports = new clsCustomerSupportCollection();

            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsCustomerSupport> TestList = new List<clsCustomerSupport>();

            //Add an Item to the List
            //create the item of test data
            clsCustomerSupport TestItem = new clsCustomerSupport();

            //set its properties
            TestItem.TicketID = 1;
            TestItem.TicketType = "Technical Support";
            TestItem.Subject = "reset password";
            TestItem.Description = "cannot reset the password";
            TestItem.SubmissionDate = DateTime.Now;
            TestItem.TicketStatus = "InProgress";
            TestItem.TicketElevated = true;

            //add the item to the test List
            TestList.Add(TestItem);

            //assign the data to the property
            AllCustomerSupports.CustomerSupportList = TestList;

            //test to see that two values are the same
            Assert.AreEqual(AllCustomerSupports.Count, TestList.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerSupportCollection AllCustomerSupports = new clsCustomerSupportCollection();

            //create the item of test data
            clsCustomerSupport TestItem = new clsCustomerSupport();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.TicketID = 1;
            TestItem.TicketType = " Support";
            TestItem.Subject = "t password";
            TestItem.Description = "cannot reset  password";
            TestItem.SubmissionDate = DateTime.Now;
            TestItem.TicketStatus = "close";
            TestItem.TicketElevated = true;

            //set ThisCustomerSupport to the test data
            AllCustomerSupports.ThisCustomerSupport = TestItem;

            //add the record
            PrimaryKey = AllCustomerSupports.Add();

            //set the primary key of the test data
            TestItem.TicketID = PrimaryKey;

            //find the record
            AllCustomerSupports.ThisCustomerSupport.Find(PrimaryKey);

            //test to see that two values are the same
            Assert.AreEqual(AllCustomerSupports.ThisCustomerSupport, TestItem);
        }
    }
}

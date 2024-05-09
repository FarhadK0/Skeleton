using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerSupport
    {
        [TestMethod]
        public void InstantOK()
        {
            //create a instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();
            //test to see that it exists
            Assert.IsNotNull(AnCustomerSupport); 
        }


             [TestMethod]

        public void TicketIDPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            Int32 TestData = 1;

            //assign the data to the property
            AnCustomerSupport.TicketID = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.TicketID, TestData);


        }

        [TestMethod]
        public void TicketTypePropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            string TestData = "Techniqal support";

            //assign the data to the property
            AnCustomerSupport.TicketType = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.TicketType, TestData);


        }

        [TestMethod]
        public void SubjectPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            string TestData = "Error";

            //assign the data to the property
            AnCustomerSupport.Subject = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.Subject, TestData);


        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            string TestData = "Full Deatails";

            //assign the data to the property
            AnCustomerSupport.Description = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.Description, TestData);


        }

        [TestMethod]
        public void SubmissionDatePropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
           DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnCustomerSupport.SubmissionDate = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.SubmissionDate, TestData);


        }

        [TestMethod]
        public void TicketStatusPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            string TestData = "Open";

            //assign the data to the property
            AnCustomerSupport.TicketStatus = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.TicketStatus, TestData);


        }

        [TestMethod]
        public void RaiseTicketPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomerSupport.RaiseTicketStatus = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.RaiseTicketStatus, TestData);


        }
    }
}

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
        public void TicketElevatedPropertyOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create some test data to assing to the property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomerSupport.TicketElevated = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnCustomerSupport.TicketElevated, TestData);


        }
        [TestMethod]
        public void FindMethoOK()
        {
            //Create an  instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //test to see if the result is true
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestTicketIDFound() 
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //Create some test data to use withe the method
            Int32 TicketID = 21;
        

             //invoke the method
             Found = AnCustomerSupport.Find(TicketID);

            //check the TicketID
            if (AnCustomerSupport.TicketID != 21)
            {
                OK = false;
            }
            

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTicketTypeFound() 
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the TicketType property
            if (AnCustomerSupport.TicketType != "TechniqalSupport")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSubjectFound() 
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Subject Property
            if (AnCustomerSupport.Subject != "Error")
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.Description != "Full Details")
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSubmissionDateFound()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the SubmissionDate Property
            if (AnCustomerSupport.SubmissionDate != Convert.ToDateTime("09/06/2024"))
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTicketStatusFound()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.TicketStatus != "InProgress")
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        public void TestTicketElevatedFound()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //create a Boolean variable to store the result of the search
            Boolean Found = false;

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 TicketID = 21;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.TicketElevated != true)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
        
    
}

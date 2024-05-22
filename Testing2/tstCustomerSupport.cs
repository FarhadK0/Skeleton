using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing2
{
    [TestClass]
    public class tstCustomerSupport
    {
        //good test data
        //create some test data to pass the method
        string TicketType = "Inquiry";
        string Subject = "CannotAccess";
        string Description = "Deatils";
        string SubmissionDate = DateTime.Now.ToShortDateString();
        string TicketStatus = "open";



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
            Int32 TicketID = 1;

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
            Int32 TicketID = 1;


            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the TicketID
            if (AnCustomerSupport.TicketID != 1)
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
            Int32 TicketID = 1;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the TicketType property
            if (AnCustomerSupport.TicketType != "CardError")
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
            Int32 TicketID = 1;

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
            Int32 TicketID = 1;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.Description != "Hello")
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
            Int32 TicketID = 1;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the SubmissionDate Property
            if (AnCustomerSupport.SubmissionDate != Convert.ToDateTime("21/05/2024"))
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
            Int32 TicketID = 1;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.TicketStatus != "open")
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
            Int32 TicketID = 1;

            //invoke the method
            Found = AnCustomerSupport.Find(TicketID);

            //check the Description Property
            if (AnCustomerSupport.TicketElevated != false)
            {
                OK = false;
            }

            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //String variable to store any error message
            String Error = "";

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]

        public void TicketTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketType = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void TicketTypeMin()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketType = "a"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void TicketTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string TicketType = "aa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketType = "aaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketTypeMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketType = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketTypeMid()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketType = "aaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketType = "aaaaaaaaaaaaaaaaaaaaa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void TicketTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustmerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketType = "";
            TicketType = TicketType.PadRight(100, 'a'); //this should fail

            //invoke the method
            Error = AnCustmerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void SubjectMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Subject = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SubjectMin()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Subject = "a"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SubjectMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string Subject = "aa"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void SubjectMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Subject = "sssssssssssssssssss"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void SubjectMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Subject = "ssssssssssssssssssss"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void SubjectMid()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Subject = "ssssssssss"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void SubjectMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Subject = "sssssssssssssssssssss"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void SubjectExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustmerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Subject = "";
            Subject = Subject.PadRight(100, 'a'); //this should fail

            //invoke the method
            Error = AnCustmerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "d"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string Description = "dd"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Description ="ddddddddddddddddddddddddddddd"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Description = "dddddddddddddddddddddddddddddd"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Description = "ddddddddddddddd"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string Description = "ddddddddddddddddddddddddddddddd"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustmerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(100, 'd'); //this should fail

            //invoke the method
            Error = AnCustmerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        public void TicketSatatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string c=variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketStatus = ""; //this should trigger an error

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void TicketStatusMin()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketStatus = "t"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void TicketStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the method
            string TicketStatus = "tt"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketStatus = "ttttttttttttttt"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketStatusMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketStatus = "tttttttttttttttt"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketStatusMid()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketStatus = "tttttttt"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void TicketStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass the method
            string TicketStatus = "ttttttttttttttttt"; //this should be ok

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the resut is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void TicketStatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustmerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string TicketStatus = "";
            TicketStatus = TicketStatus.PadRight(100, 't'); //this should fail

            //invoke the method
            Error = AnCustmerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SubmissionDateExtremeMin()
        {
            //create an instance of the class we want ro create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string SubmissionDate = TestDate.ToString();

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]

        public void SubmissionDateMinLessOne()
        {
            //create an instance of the class we want ro create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string SubmissionDate = TestDate.ToString();

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]

        public void SubmissionDateMin()
        {
            //create an instance of the class we want ro create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

          
            //convert the date variable to a string variable
            string SubmissionDate = TestDate.ToString();

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]

        public void SubmissionDateMinPlusOne()
        {
            //create an instance of the class we want ro create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string SubmissionDate = TestDate.ToString();

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]

        public void SubmissionDateExtremeMax()
        {
            //create an instance of the class we want ro create 
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string SubmissionDate = TestDate.ToString();

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void SubmissionDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();

            //string variable to store any error message
            String Error = "";

            //set the submissionDate to a non date value
            string SubmissionDate = "This is not a date!";

            //invoke the method
            Error = AnCustomerSupport.Valid(TicketType, Subject, Description, SubmissionDate, TicketStatus);

            //test to see that the result is correcrt
            Assert.AreNotEqual(Error, "");

        }
    }

}


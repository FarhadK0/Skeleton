using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method 
        string StaffName = "John";
        string StaffEmail = "John@gmail.com";
        string DateOfBirth = new DateTime(1999, 12, 14).ToShortDateString();
        string StaffAddress = "15 Castle Street";
        string StaffAge = "25";

        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of a class.
            clsStaff AStaff = new clsStaff();
            // test to see that it exists.
            Assert.IsNotNull(AStaff);

        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            Int32 TestData = 4;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffId, TestData);

        }

        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "John Micheal";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffName, TestData);

        }

        [TestMethod]
        public void StaffEmailOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "JohnMicheal@gmail.com";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffEmail, TestData);

        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            DateTime TestData = new DateTime(1990, 5, 13); // Example date of birth
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.DateOfBirth, TestData);

        }

        [TestMethod]
        public void StaffAddressOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "33 castle street LE2 5WL";
            //assign the data to the property
            AStaff.StaffAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffAddress, TestData);

        }

        [TestMethod]
        public void StaffAgeOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            Int32 TestData = 34;
            //assign the data to the property
            AStaff.StaffAge = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.StaffAge, TestData);

        }

        [TestMethod]
        public void IsManagerOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AStaff.IsManager = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.IsManager, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true  
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff Id
            if (AStaff.StaffId != 4)
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff Name
            if (AStaff.StaffName != "Daniel Johnson")
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff Email
            if (AStaff.StaffEmail != "DanielJohnson@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Date Of Birth
            if (AStaff.DateOfBirth != Convert.ToDateTime("15/4/1997"))
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Address Id
            if (AStaff.StaffAddress != "16 Castle Street LE2 5WL")
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffAgeFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Address Id
            if (AStaff.StaffAge != 27)
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Address Id
            if (AStaff.IsManager != true)
            {
                OK = false;
            }
            //test to see if the result is true  
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "a"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "aa"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a'); //This should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "";
            StaffName = StaffName.PadRight(100000, 'a'); //This should trigger an error
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "a"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "aa"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'a'); //This should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'a'); //This should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(100000, 'a'); //This should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to a valid date of birth 
            TestDate = new DateTime(2004, 1, 10);
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to a valid date of birth 
            TestDate = new DateTime(2004, 1, 10);
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToShortDateString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to the a valid date of birth 
            TestDate = new DateTime(2004, 1, 10);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to a valid date of birth 
            TestDate = new DateTime(2004, 1, 10);
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToShortDateString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to a valid date of birth 
            TestDate = new DateTime(2004, 1, 10);
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = ""; //this should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMin()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "a"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "aa"; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(49, 'a'); //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'a'); //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(51, 'a'); //this should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(25, 'a'); //this should be ok
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            //create an instance of the class we want to create.
            clsStaff AStaff = new clsStaff();
            //string c = variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(10000, 'a'); //this should fail
            //invoke the method 
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years
            TestAge = 18;
            //change the age to 1 years
            TestAge = 1;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffAgeMinOneless()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years
            TestAge = 18;
            //change the age to 17 years
            TestAge = 17;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years
            TestAge = 18;
            //change the age to 18 years
            TestAge = 18;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years
            TestAge = 18;
            //change the age to 19 years
            TestAge = 19;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMaxOneLess()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age 18 years 
            TestAge = 18;
            //change the age 64 years
            TestAge = 64;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years
            TestAge = 18;
            //change the age to 65 years
            TestAge = 65;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18 years 
            TestAge = 18;
            //change the age to 66 years
            TestAge = 66;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAgeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18
            TestAge = 18;
            //change the age to 118 years 
            TestAge = 33;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffAgeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test age data
            Int32 TestAge;
            //set the age to 18
            TestAge = 18;
            //change the age to 118 years 
            TestAge = 118;
            //convert the int variable to a string variable
            string StaffAge = TestAge.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, DateOfBirth, StaffAddress, StaffAge);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }










































    }
}
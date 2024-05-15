using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
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
            Int32 StaffId = 15;
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
            if(AStaff.StaffId != 4)
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
            Int32 StaffId = 15;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff Name
            if (AStaff.StaffName != "John Micheal")
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
            Int32 StaffId = 15;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff Email
            if (AStaff.StaffEmail != "JohnMicheal@gmail.com")
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
            Int32 StaffId = 15;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Date Of Birth
            if (AStaff.DateOfBirth != Convert.ToDateTime("13/5/1990"))
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
            Int32 StaffId = 15;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Address Id
            if (AStaff.StaffAddress != "33 Castle Street LE2 5WL")
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
            Int32 StaffId = 15;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Address Id
            if (AStaff.StaffAge != 34)
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
            Int32 StaffId = 15;
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






    }
}
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
        public void StaffAge()
        {
            //create an instance of the class we want.
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property 
            Int32 TestData = 1;
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



    }
}

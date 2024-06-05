using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create an intance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data too assign to the property 
            Int32 TestData = 1;
            //assign the data to property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Jainish";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Jainish8";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the sam
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Customer";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void TestUserNmaePWFound() 
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean variable to store the result of search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            string UserName = "Jainish";
            string Password = "Jainish8";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if(AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that  the result is correct
            Assert.IsTrue(OK);
        }
    }
}

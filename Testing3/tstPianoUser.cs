using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace Testing3
{
    [TestClass]
    public class tstPianoUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPianoUser anUser = new clsPianoUser();
            //test to see if it exists
            Assert.IsNotNull(anUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the PianoUser class
            clsPianoUser anUser = new clsPianoUser();
            //create some test data to assign to the property
            Int32 testData = 1;
            //assign the data to the property
            anUser.UserId = testData;
            //test
            Assert.AreEqual(anUser.UserId, testData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsPianoUser AnUser = new clsPianoUser();
            //create some test data to assign to the property
            string TestData = "Wataru";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsPianoUser AnUser = new clsPianoUser();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsPianoUser AnUser = new clsPianoUser();
            //create some test data to assign to the property
            string TestData = "Piano";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the piano user
            clsPianoUser AnUser = new clsPianoUser();
            //bool var for storing the results of the validation
            Boolean Found = false;
            //test data
            string username = "Wataru";
            string password = "password";
            //invoke find method
            Found = AnUser.FindUser(username, password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the piano user
            clsPianoUser AnUser = new clsPianoUser();
            //bool val to store the result of the search
            Boolean Found = false;
            //bool val to record if the data is OK
            Boolean OK = true;
            //test data
            string username = "Wataru";
            string password = "password";
            //invoke find method
            Found = AnUser.FindUser(username, password);
            //check the user id property
            if (AnUser.UserName != username && AnUser.Password != password) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

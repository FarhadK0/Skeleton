using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstPurchasesUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test
            Assert.IsNotNull(AnUser);

        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            Int32 TestData = 1;

            //Assign data to property
            AnUser.UserID = TestData;

            //Test to see if values are the same
            Assert.AreEqual(AnUser.UserID, TestData);

        }

        [TestMethod]
        public void UserNamePropertyOK() 
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            string TestData = "Terun";

            //Assign data to property
            AnUser.UserName = TestData;

            //Test to see that the two values are same
            Assert.AreEqual(AnUser.UserName, TestData);

        }

        [TestMethod]
        public void PasswordPropertyOK() 
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            string TestData = "Purchases";

            //Assign data to property
            AnUser.Password = TestData;

            //Test to see that the two values are same
            Assert.AreEqual(AnUser.Password, TestData);

        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            string TestData = "Purchases";

            //Assign data to property
            AnUser.Department = TestData;

            //Test to see that the two values are same
            Assert.AreEqual(AnUser.Department, TestData);

        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            Boolean Found = false;

            //Test data
            string UserName = "Terun";
            string Password = "Purchases";

            //Invoke the method
            Found = AnUser.FindUser(UserName, Password);

            //Test to see that the two values are same
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestUserPWFound()
        {
            //Instance created
            clsPurchaseUser AnUser = new clsPurchaseUser();

            //Test data
            Boolean Found = false;

            //Boolean created to record if data is OK
            Boolean OK = true;

            //Test data
            string UserName = "Terun";
            string Password = "Purchases";

            //Method invoked
            Found = AnUser.FindUser(UserName, Password);

            //Check the user property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //Test to see results are correct
            Assert.IsTrue(OK);

        }
    }
}

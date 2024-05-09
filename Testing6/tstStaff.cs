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
            //create an instance of a class 'staff Name'.
            clsStaff AStaff = new clsStaff();
            //assigning the data
            string TestData = "Staff Name";
            AStaff.StaffName = TestData;
            Assert.AreEqual(AStaff.StaffName, TestData);

        }
    }
}

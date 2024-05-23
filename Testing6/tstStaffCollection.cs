using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Testing6
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of a class.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // test to see that it exists.
            Assert.IsNotNull(AllStaffs);

        }


        [TestMethod]
        public void StaffListOK()
        {
            //creating an instance of the class we want to create.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //sets its properties
            TestItem.IsManager = true;
            TestItem.StaffId = 2;
            TestItem.StaffName = "John";
            TestItem.StaffEmail = "John@gmail.com";
            TestItem.StaffRegisterDate = DateTime.Now;
            TestItem.StaffAddress = "15 Castle Street";
            TestItem.StaffAge = 25;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.StaffList, TestList);



        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //creating an instance of the class we want to create.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property 
            clsStaff TestStaff = new clsStaff();
            //sets the properties of the test object
            TestStaff.IsManager = true;
            TestStaff.StaffId = 2;
            TestStaff.StaffName = "John";
            TestStaff.StaffEmail = "John@gmail.com";
            TestStaff.StaffRegisterDate = DateTime.Now;
            TestStaff.StaffAddress = "15 Castle Street";
            TestStaff.StaffAge = 25;
            //assign the data to the property 
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);



        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //creating an instance of the class we want to create.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //sets its properties
            TestItem.IsManager = true;
            TestItem.StaffId = 2;
            TestItem.StaffName = "John";
            TestItem.StaffEmail = "John@gmail.com";
            TestItem.StaffRegisterDate = DateTime.Now;
            TestItem.StaffAddress = "15 Castle Street";
            TestItem.StaffAge = 25;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.Count, TestList.Count);



        }


        [TestMethod]
        public void AddMethodOK()
        {
            //creating an instance of the class we want to create.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //sets its properties
            TestItem.IsManager = true;
            TestItem.StaffId = 2;
            TestItem.StaffName = "John";
            TestItem.StaffEmail = "John@gmail.com";
            TestItem.StaffRegisterDate = DateTime.Now;
            TestItem.StaffAddress = "15 Castle Street";
            TestItem.StaffAge = 25;
            //set ThisStaff to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record 
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);



        }

        

        [TestMethod]
        public void UpdateMethodOK()
        {
            //creating an instance of the class we want to create.
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //sets its properties
            TestItem.IsManager = true;
            TestItem.StaffId = 2;
            TestItem.StaffName = "John";
            TestItem.StaffEmail = "John@gmail.com";
            TestItem.StaffRegisterDate = DateTime.Now;
            TestItem.StaffAddress = "15 Castle Street";
            TestItem.StaffAge = 25;
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.IsManager = false;
            TestItem.StaffId = 11;
            TestItem.StaffName = "Sarah";
            TestItem.StaffEmail = "Sarah@gmail.com";
            TestItem.StaffRegisterDate = DateTime.Now;
            TestItem.StaffAddress = "158 Newarke Street";
            TestItem.StaffAge = 25;
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);



        }

        



    }
}

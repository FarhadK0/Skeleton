﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net.Mail;

namespace Testing5
{

    [TestClass]
    public class tstPurchases
    {
        //Good Test Data
        string CustomerName = "Chloe Hans";
        string DeliveryOptions = "Morning";
        string ProductPrice = "13.99";
        string Quantity = "3";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalAmount = "41.97";

    

        [TestMethod]
        public void InstanceOK()
        {
            // create a new instance of Purchases
            clsPurchases APurchase = new clsPurchases();

            // test if it exists
            Assert.IsNotNull(APurchase);
        }

        [TestMethod]
        public void PurchaseIdOK()
        {
            //New instance of Purchase
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            Int32 TestData = 1;

            //Assign the data to the PurchaseId
            APurchase.PurchaseId = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(APurchase.PurchaseId, TestData);

        }

        [TestMethod]
        public void DateAddedOK()
        {
            //new instance of purchase
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            DateTime testOrderDate = DateTime.Now.Date;

            //Assign data to the OrderDate
            APurchase.OrderDate = testOrderDate;

            //test
            Assert.AreEqual(APurchase.OrderDate, testOrderDate);

        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //New Instance of CustomerName
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            string testCustomerName = "Chloe Hans";

            //Assign data to the CustomerName
            APurchase.CustomerName = testCustomerName;

            //test
            Assert.AreEqual(APurchase.CustomerName, testCustomerName);

        }

        [TestMethod]
        public void DeliveryOptionsOK()
        {
            //New Instance of DeliveryOptions
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            string testDeliveryOptions = "Morning";

            //Assign data to the DeliveryOptions
            APurchase.DeliveryOptions = testDeliveryOptions;

            //test
            Assert.AreEqual(APurchase.DeliveryOptions, testDeliveryOptions);

        }

        [TestMethod]
        public void ProductPriceOK()
        {
            //New Instance of ProductPrice
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            double testProductPrice = 1;

            //Assign data to the ProductPrice
            APurchase.ProductPrice = testProductPrice;

            //test
            Assert.AreEqual(APurchase.ProductPrice, testProductPrice);

        }

        [TestMethod]
        public void QuantityOK()
        {
            //New Instance of Quantity
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            Int32 testQuantity = 1;

            //Assign data to the ProductPrice
            APurchase.Quantity = testQuantity;

            //test
            Assert.AreEqual(APurchase.Quantity, testQuantity);

        }

        [TestMethod]
        public void TotalAmountOK()
        {
            //New Instance of TotalAmount
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            double testTotalAmount = 1;

            //Assign data to the ProductPrice
            APurchase.TotalAmount = testTotalAmount;

            //test
            Assert.AreEqual(APurchase.TotalAmount, testTotalAmount);

        }

        [TestMethod]
        public void OrderConfirmedOK()
        {
            //New Instance of TotalAmount
            clsPurchases APurchase = new clsPurchases();

            //some test data to assign to the Purchase
            Boolean testOrderConfirmed = true;

            //Assign data to the ProductPrice
            APurchase.OrderConfirmed = testOrderConfirmed;

            //test
            Assert.AreEqual(APurchase.OrderConfirmed, testOrderConfirmed);

        }

        /***FIND METHOD TEST***/
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsPurchases APurchase = new clsPurchases();

            //Create a boolean variable to store the results of the validation
            Boolean Found = false;

            //Create some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoke the method
            Found = APurchase.Find(PurchaseId);

            //Test to see if the result is true
            Assert.IsTrue(Found);
        }
        /***ATTRIBUTE DATA TESTS***/
        [TestMethod]
        public void TestPurchaseIdFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //checking PurchaseId
            if (APurchase.PurchaseId != 8)
            {
                OK = false;
            }

            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check the OrderDate Property
            if (APurchase.OrderDate != Convert.ToDateTime("15/04/2024"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check the CustomerName Property
            if (APurchase.CustomerName != "Tel Tel")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryOptionsFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check the DeliveryOptions Property
            if (APurchase.DeliveryOptions != "Morning")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check the ProductPrice Property
            if (APurchase.ProductPrice != Convert.ToDouble("5"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //checking Quantity Property
            if (APurchase.Quantity != 1)
            {
                OK = false;
            }

            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check the ProductPrice Property
            if (APurchase.TotalAmount != Convert.ToDouble("5"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderConfirmedFound()
        {
            //Create an instance of the class we want to create 
            clsPurchases APurchase = new clsPurchases();

            //Create a Boolean variable to store the result of the search
            Boolean Found = false;

            //Create a Boolean variable to record if the data is OK
            Boolean OK = true;

            //Some test data to use with the method
            Int32 PurchaseId = 8;

            //Invoked Method
            Found = APurchase.Find(PurchaseId);

            //Check OrderConfirmed Property
            if (APurchase.OrderConfirmed != true)
            {
                OK = false;
            }

            //test to see that result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
             String Error = "";

            //Method Invoked
            Error = APurchase.Valid(CustomerName,DeliveryOptions,ProductPrice,Quantity,OrderDate,TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        //---------------------------------------------- (CUSTOMER NAME VALID METHOD)

        [TestMethod]
        public void CustomerNameMinMinusOne()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = ""; 

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        //This is the CustomerName Valid Method
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "**";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "*";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxMinusOne()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "*"; //Should be Ok
            CustomerName.PadRight(49, '*');

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "*"; //Should be Ok
            CustomerName.PadRight(50, '*');
            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "";
            CustomerName.PadRight(51, '*');
            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "*"; //Should be Ok
            CustomerName = CustomerName.PadRight(25, '*');
            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string CustomerName = "*"; //Should be Ok
           CustomerName = CustomerName.PadRight(500, '*');

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---------------------------------------------- (DELIVERY OPTIONS VALID METHOD)

        [TestMethod]
        public void DeliveryOptionsMinMinusOne()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        //This is the CustomerName Valid Method
        [TestMethod]
        public void DeliveryOptionsMinPlusOne()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "**";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsMin()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "*";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsMaxMinusOne()
        {

            //This is the CustomerName Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "*"; //Should be Ok
            DeliveryOptions.PadRight(149, '*');

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsMax()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "*"; //Should be Ok
            DeliveryOptions.PadRight(150, '*');

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsMaxPlusOne()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = "";
            DeliveryOptions.PadRight(151, '*');
            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsMid()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = ""; //Should be Ok
            DeliveryOptions = DeliveryOptions.PadRight(75, '*');
            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryOptionsExtremeMax()
        {

            //This is the DeliveryOptions Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string DeliveryOptions = ""; //Should be Ok
            DeliveryOptions = DeliveryOptions.PadRight(750, '*');

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---------------------------------------------- (PRODUCT PRICE VALID METHOD)


        [TestMethod]
        public void ProductPriceExtremeMin()
        {

            //This is the ProductPrice Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string ProductPrice = "-10,000";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinMinusOne()
        {

            //This is the ProductPrice Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string ProductPrice = "-0.01";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //This is the ProductPrice Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string ProductPrice = "0.01";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMin()
        {

            //This is the ProductPrice Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string ProductPrice = "0.00";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductPriceInvalidDataType()
        {
            //create an instance of the class we want to create
            clsPurchases APurchase = new clsPurchases();

            //string variable to store any error message
            String Error = "";

            //set target test data
            string ProductPrice = "ProductPrice";

            //invoke the method
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);    
            
            //Test to see if result is correct
            Assert.AreNotEqual(Error, ""); 
        }

        //---------------------------------------------- (TOTAL AMOUNT VALID METHOD)


        [TestMethod]
        public void TotalAmountExtremeMin()
        {

            //This is the TotalAmount Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string TotalAmount = "-10,000,000";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinMinusOne()
        {

            //This is the TotalAmount Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string TotalAmount = "-0.01";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            //This is the TotalAmount Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string TotalAmount = "0.01";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {

            //This is the TotalAmount Valid Method

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string TotalAmount = "0.00";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidDataType()
        {
            //create an instance of the class we want to create
            clsPurchases APurchase = new clsPurchases();

            //string variable to store any error message
            String Error = "";

            //set target test data
            string TotalAmount = "TotalAmount";

            //invoke the method
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---------------------------------------------- (QUANTITY VALID METHOD)


        [TestMethod]
            public void QuantityMinMinusOne()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "0";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void QuantityMin()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "1";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreEqual(Error, "");
            }

            
            [TestMethod]
            public void QuantityMinPlusOne()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "2";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityMaxMinusOne()
            {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "249";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreEqual(Error, "");

            }

            [TestMethod]
            public void QuantityMax()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string TotalAmount = "250";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void QuantityMaxPlusOne()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "251";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreNotEqual(Error, "");
            }

            //This is the Quantity Valid Method
            [TestMethod]
            public void QuantityMid()
            {

                //Instance of Class Created
                clsPurchases APurchase = new clsPurchases();

                //String Variable to store error message
                String Error = "";

                //Some test date to pass method
                string Quantity = "125";

                //Method Invoked
                Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

                //Test to see if result is correct
                Assert.AreEqual(Error, "");
            }

        [TestMethod]
        public void QuantityExtremeMax()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string Quantity = "500";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityInvalidDataType()
        {

            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Some test date to pass method
            string Quantity = "Quantity";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }

        //---------------------------------------------- (ORDER DATE VALID METHOD)

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Create variable to store the test date data
            DateTime TestDate;

            //Set date to todays date
            TestDate = DateTime.Now.Date;

            //Change date to whatever date is minus 10 years
            TestDate = TestDate.AddYears(-10);

            //Convert date variable to a string variable
            string OrderDate = TestDate.ToString();

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinMinusOne()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Create variable to store the test date data
            DateTime TestDate;

            //Set date to todays date
            TestDate = DateTime.Now.Date;

            //Change date to whatever date is minus one day.
            TestDate = TestDate.AddDays(-1);

            //Convert date variable to a string variable
            string OrderDate = TestDate.ToString();

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Create variable to store the test date data
            DateTime TestDate;

            //Set date to todays date
            TestDate = DateTime.Now.Date;

            //Change date to whatever date is less 1 day
            TestDate = TestDate.AddDays(1);

            //Convert date variable to a string variable
            string OrderDate = TestDate.ToString();

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMin()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Create variable to store the test date data
            DateTime TestDate;

            //Set date to todays date
            TestDate = DateTime.Now.Date;

            //Convert date variable to a string variable
            string OrderDate = TestDate.ToString();

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Create variable to store the test date data
            DateTime TestDate;

            //Set date to todays date
            TestDate = DateTime.Now.Date;

            //Change date to whatever date is plus 10 years
            TestDate = TestDate.AddYears(10);

            //Convert date variable to a string variable
            string OrderDate = TestDate.ToString();

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //Instance of Class Created
            clsPurchases APurchase = new clsPurchases();

            //String Variable to store error message
            String Error = "";

            //Set the OrderDate to a non data value
            string OrderDate = "This is not a date!";

            //Method Invoked
            Error = APurchase.Valid(CustomerName, DeliveryOptions, ProductPrice, Quantity, OrderDate, TotalAmount);

            //Test to see if result is correct
            Assert.AreNotEqual(Error, ""); 


        }
    }
}
















































       
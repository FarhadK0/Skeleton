using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstPurchases
    {

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
            if (APurchase.OrderDate != Convert.ToDateTime ("15/04/2024"))
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
            if (APurchase.ProductPrice !=Convert.ToDouble ("5"))
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
    }
    }















































       
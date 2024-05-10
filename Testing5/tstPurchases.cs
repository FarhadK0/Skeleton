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
            decimal testProductPrice = 1;

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
            decimal testTotalAmount = 1;

            //Assign data to the ProductPrice
            APurchase.TotalAmount = testTotalAmount;

            //test
            Assert.AreEqual(APurchase.TotalAmount, testTotalAmount);

        }
    }
}

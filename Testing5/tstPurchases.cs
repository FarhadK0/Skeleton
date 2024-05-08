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
    }
}

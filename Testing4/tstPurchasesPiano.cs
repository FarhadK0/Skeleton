using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPurchasesPiano
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the PurchasesPiano class
            clsPurchasesPiano aPurchasesPiano = new clsPurchasesPiano();
            //instantiation test
            Assert.IsNotNull(aPurchasesPiano);
        }

        [TestMethod]
        public void PianoIdOK()
        {
            //create a new instance of the PurchasesPiano class
            clsPurchasesPiano aPurchasesPiano = new clsPurchasesPiano();
            //test data
            Int32 testPianoId= 1;
            //assign test data to cls property
            aPurchasesPiano.PianoId = testPianoId;
            //test if both values match
            Assert.AreEqual(aPurchasesPiano.PianoId, testPianoId);
            
        }

        [TestMethod]
        public void PurchasesIdOK()
        {
            //create a new instance of the PurchasesPiano class
            clsPurchasesPiano aPurchasesPiano = new clsPurchasesPiano();
            //test data
            Int32 testPurchasesId = 1;
            //assign test data to cls property
            aPurchasesPiano.PurchasesId = testPurchasesId;
            //test if both values match
            Assert.AreEqual(aPurchasesPiano.PurchasesId, testPurchasesId);

        }
    }
}

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
    }
}

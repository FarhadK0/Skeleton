using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerSupport
    {
        [TestMethod]
        public void InstantOK()
        {
            //create a instance of the class we want to create
            clsCustomerSupport AnCustomerSupport = new clsCustomerSupport();
            //test to see that it exists
            Assert.IsNotNull(AnCustomerSupport); 
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstPiano
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create a new instance of Piano
            clsPiano aPiano = new clsPiano();

            // test if it exists
            Assert.IsNotNull(aPiano);
        }
    }
}

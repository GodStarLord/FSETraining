using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportManagementBLLibrary;

namespace TransportTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleTestCase()
        {
            BusinessLogic businessLogic = new BusinessLogic();

            int result = businessLogic.TestCheck();
            Assert.AreEqual(100, result);
            //comment out connection statement in Business Logic
        }

        [TestMethod]
        public void SampleTest2()
        {
            BusinessLogic businessLogic = new BusinessLogic();

            int result = businessLogic.TestCheck2().Count;
            Assert.AreEqual(2,result);
        }
    }
}

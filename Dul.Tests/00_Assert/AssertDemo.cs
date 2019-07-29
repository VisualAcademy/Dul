using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dul.Tests
{
    [TestClass]
    public class AssertDemo
    {
        [TestMethod]
        public void AssertAreEqualTest()
        {
            Assert.AreEqual(1234, 1234);
        }
    }
}

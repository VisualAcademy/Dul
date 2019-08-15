using Microsoft.VisualStudio.TestTools.UnitTesting;

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

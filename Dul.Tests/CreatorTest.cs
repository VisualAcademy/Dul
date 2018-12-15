using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            var expected = "RedPlus";

            var actual = Creator.GetName();

            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            //[1] Arrange, Setup
            var expected = "RedPlus";

            //[2] Act, Execute
            var actual = Creator.GetName();

            //[3] Assert, Verify
            Assert.AreEqual(expected, actual);
        }
    }
}

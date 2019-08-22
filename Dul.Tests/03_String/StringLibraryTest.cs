using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class StringLibraryTest
    {
        [TestMethod]
        public void CutStringTest()
        {
            //[1] Arrange
            var expected = "안녕하...";

            //[2] Act
            var actual = "안녕하세요.".CutStringUnicode(6);

            //[3] Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

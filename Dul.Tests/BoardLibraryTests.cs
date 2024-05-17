using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class BoardLibraryTests
    {
        [TestMethod]
        public void FuncFileDownSingle_WithValidParameters_ReturnsAnchorTag()
        {
            // Arrange
            int id = 1;
            string strFileName = "test.txt";
            string strFileSize = "1024";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize);

            // Assert
            Assert.AreEqual("<a href=\"/DotNetNote/BoardDown.aspx?Id=1\">"
                + "<img src='/images/ext/ext_txt.gif' border='0' alt='test.txt(1 KB)'></a>", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithNullParameters_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = null;
            string strFileSize = "1024";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize);

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithEmptyFileName_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = "";
            string strFileSize = "1024";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize);

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFolder_ValidParameters_ReturnsAnchorTag()
        {
            // Arrange
            int id = 1;
            string strFileName = "test.txt";
            string strFileSize = "1024";
            string folder = "uploads";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder);

            // Assert
            Assert.AreEqual("<a href=\"/uploads/BoardDown.aspx?Id=1\">"
                + "<img src='/images/ext/ext_txt.gif' border='0' alt='test.txt(1 KB)'></a>", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFolder_NullParameters_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = null;
            string strFileSize = "1024";
            string folder = "uploads";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder);

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFolder_EmptyFileName_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = "";
            string strFileSize = "1024";
            string folder = "uploads";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder);

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFile_ValidParameters_ReturnsAnchorTag()
        {
            // Arrange
            int id = 1;
            string strFileName = "test.txt";
            string strFileSize = "1024";
            string folder = "uploads";
            string file = "/file";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder, file);

            // Assert
            Assert.AreEqual("<a href=\"/uploads/file?Id=1\">"
                + "<img src='/images/ext/ext_txt.gif' border='0' alt='test.txt(1 KB)'></a>", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFile_NullParameters_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = null;
            string strFileSize = "1024";
            string folder = "uploads";
            string file = "/file";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder, file);

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void FuncFileDownSingle_WithFile_EmptyFileName_ReturnsDash()
        {
            // Arrange
            int id = 1;
            string strFileName = "";
            string strFileSize = "1024";
            string folder = "uploads";
            string file = "/file";

            // Act
            string result = BoardLibrary.FuncFileDownSingle(id, strFileName, strFileSize, folder, file);

            // Assert
            Assert.AreEqual("-", result);
        }
    }
}

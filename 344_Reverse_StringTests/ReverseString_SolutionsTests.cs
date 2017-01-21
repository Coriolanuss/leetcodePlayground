using Microsoft.VisualStudio.TestTools.UnitTesting;
using _344_Reverse_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344_Reverse_String.Tests
{
    [TestClass()]
    public class ReverseString_SolutionsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void ReverseStringUsingTempStringTest()
        {
            // Arrange
            string input = Convert.ToString(TestContext.DataRow["text"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // Act
            string actual = ReverseString_Solutions.ReverseStringUsingTempString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void ReverseStringUsingStringBuilderTest()
        {
            // Arrange
            string input = Convert.ToString(TestContext.DataRow["text"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // Act
            string actual = ReverseString_Solutions.ReverseStringUsingStringBuilder(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void ReverseStringUsingArrayOfCharsTest()
        {
            // Arrange
            string input = Convert.ToString(TestContext.DataRow["text"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // Act
            string actual = ReverseString_Solutions.ReverseStringUsingArrayOfChars(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
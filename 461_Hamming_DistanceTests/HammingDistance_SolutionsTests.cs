using Microsoft.VisualStudio.TestTools.UnitTesting;
using _461_Hamming_Distance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461_Hamming_Distance.Tests
{
    [TestClass()]
    public class HammingDistance_SolutionsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void HammingDistanceTestWithStringManipulations()
        {
            // arrange
            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            // act
            int actual = HammingDistance_Solutions.HammingDistanceWithStringManipulations(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void HammingDistanceWithXORTest()
        {
            // arrange
            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            // act
            int actual = HammingDistance_Solutions.HammingDistanceWithXOR(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
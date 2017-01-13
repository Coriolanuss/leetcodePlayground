using Microsoft.VisualStudio.TestTools.UnitTesting;
using _412_Fizz_Buzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412_Fizz_Buzz.Tests
{
    [TestClass()]
    public class FizzBuzz_SolutionsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void SelectRespondTest()
        {
            // Arrange
            int numb = Convert.ToInt32(TestContext.DataRow["number"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // Act
            string actual = FizzBuzz_Solutions.SelectRespond(numb);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
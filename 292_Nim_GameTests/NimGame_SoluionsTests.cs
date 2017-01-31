using Microsoft.VisualStudio.TestTools.UnitTesting;
using _292_Nim_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _292_Nim_Game.Tests
{
    [TestClass()]
    public class NimGame_SoluionsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        public void CanWinNimMyFirstSolutionTest()
        {
            // Arrange
            int numberOfStones = Convert.ToInt32(TestContext.DataRow["numb"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);

            // Act
            bool actual = NimGame_Soluions.CanWinNimMyFirstSolution(numberOfStones);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "ExceptionTestData.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), AllowDerivedTypes = true)]
        public void CanWinNimMyFirstSolutionTestExceptions()
        {
            // Arrange
            int numberOfStones = Convert.ToInt32(TestContext.DataRow["numb"]);

            // Act
            NimGame_Soluions.CanWinNimMyFirstSolution(numberOfStones);
        }
    }
}
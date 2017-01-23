using Microsoft.VisualStudio.TestTools.UnitTesting;
using _463_Island_Perimeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463_Island_Perimeter.Tests
{
    [TestClass()]
    public class IslandPerimeter_SolutionsTests
    {
        // TODO Create XML-file to store test cases (to create normal data-driven test)

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase1_Returns16()
        {
            // Arrange
            int[,] input = {
                {0, 1, 0, 0 },
                {1, 1, 1, 0 },
                {0, 1, 0, 0 },
                {1, 1, 0, 0 }};
            int expected = 16;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase2_Returns0()
        {
            // Arrange
            int[,] input = {
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 }};
            int expected = 0;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase3_Returns4()
        {
            // Arrange
            int[,] input = {
                {1, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 }};
            int expected = 4;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase4_Returns16()
        {
            // Arrange
            int[,] input = {
                {1, 1, 1, 1 },
                {1, 1, 1, 1 },
                {1, 1, 1, 1 },
                {1, 1, 1, 1 }};
            int expected = 16;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase5TwoIslands_Returns16()
        {
            // Arrange
            int[,] input = {
                {1, 1, 0, 0 },
                {1, 1, 0, 0 },
                {0, 0, 0, 1 },
                {0, 0, 1, 1 }};
            int expected = 16;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IslandPerimeterUsingCycleAndNeighborCheckTest_TestCase6InnerLake_Returns16()
        {
            // Arrange
            int[,] input = {
                {1, 1, 1, 0 },
                {1, 0, 1, 0 },
                {1, 1, 1, 0 },
                {0, 0, 0, 0 }};
            int expected = 16;

            // Act
            int actual = IslandPerimeter_Solutions.IslandPerimeterUsingCycleAndNeighborCheck(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
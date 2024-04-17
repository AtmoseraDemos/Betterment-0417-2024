using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathFun.Tests
{
    [TestClass]
    public class ProbabilitiesTests
    {
        [TestMethod]
        public void TestPermutations()
        {
            // Arrange
            uint n = 5;
            uint r = 3;
            ulong expected = 60;

            // Act
            ulong result = Probabilites.Permutations(n, r);

            // Assert
            Assert.AreEqual(expected, result, "The permutations calculation is not correct");
        }
    }
}
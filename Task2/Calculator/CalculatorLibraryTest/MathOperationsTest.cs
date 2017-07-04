using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
namespace CalculatorLibraryTest
{
    [TestClass]
    class MathOperationsTest
    {
        [TestMethod]
        public void sumTest()
        {
            var _Mo = new MathOperations();

            int expected = 5;
            int actual = _Mo.Sum("2,3");
            Assert.AreEqual(expected, actual, "The Expected result is not equal to Actual result");
        }

        [TestMethod]
        public void AddTest()
        {
            var _Mo = new MathOperations();

            int expected = 133;
            int actual = _Mo.Sum(" 4,7,3,4,7,3,5,6,7,4,3,2,5,7,5,3,4,6,7,8,9,5,5,5,4,3,2");
            Assert.AreEqual(expected, actual, "The Expected result is not equal to Actual result");
        }
    }
}

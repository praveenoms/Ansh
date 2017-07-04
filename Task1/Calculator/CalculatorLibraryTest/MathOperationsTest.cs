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
    }
}

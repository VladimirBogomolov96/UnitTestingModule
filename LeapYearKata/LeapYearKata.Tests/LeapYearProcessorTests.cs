using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeapYearKata.Tests
{
    [TestClass]
    public class LeapYearProcessorTests
    {
        private LeapYearProcessor processor = new LeapYearProcessor();

        [TestMethod]
        [DataRow(0, true)]
        [DataRow(2000, true)]
        [DataRow(2001, false)]
        [DataRow(2100, false)]
        [DataRow(-100, false)]
        [DataRow(-104, true)]
        [DataRow(2147483647, false)]
        [DataRow(-2147483648, true)]
        public void IsLeapYear_ValidValues_ReturnsCorrectResult(int year, bool expectedResult)
        {
            // Act
            bool result = this.processor.IsLeapYear(year);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

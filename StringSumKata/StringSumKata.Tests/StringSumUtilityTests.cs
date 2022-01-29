using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringSumKata.Tests
{
    [TestClass]
    public class StringSumUtilityTests
    {
        private StringSumUtility stringSumUtility = new StringSumUtility();

        [TestMethod]
        [DataRow("", "", "0")]
        [DataRow(null, null, "0")]
        [DataRow("", "22", "22")]
        [DataRow("33", null, "33")]
        [DataRow("dsfa", "hfdghd", "0")]
        [DataRow("gdfgsg", "12345", "12345")]
        [DataRow("sdffs324", "66", "66")]
        [DataRow("-754", "-111", "-865")]
        [DataRow("3244.6", "34,533", "0")]
        public void Sum_ValidInput_ReturnsCorrectResult(string num1, string num2, string expectedResult)
        {
            // Act
            string result = this.stringSumUtility.Sum(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

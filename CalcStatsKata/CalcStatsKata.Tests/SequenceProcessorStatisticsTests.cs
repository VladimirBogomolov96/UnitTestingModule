using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalcStatsKata.Tests
{
    [TestClass]
    public class SequenceProcessorStatisticsTests
    {
        private SequenceProcessor sequenceProcessor = new SequenceProcessor();

        private int[][] testCases = new int[][]
        {
            new int[]{ 5, 0, 4 },
            new int[]{ -7, 2 },
            new int[]{ 23424, -315125, 5352151, 98003, -342151234, 234123512, -956459687 },
            new int[]{ 0 },
            new int[]{ 2147483647, -2147483648 },
        };

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProcessSequence_SequenceIsNull_ThrowsArgumentNullException()
        {
            // Act
            this.sequenceProcessor.ProcessSequence(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProcessSequence_SequenceIsEmpty_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<int> sequence = new int[0];

            // Act
            this.sequenceProcessor.ProcessSequence(sequence);
        }

        [TestMethod]
        [DataRow(0, 5, 0, 3, 3)]
        [DataRow(1, 2, -7, 2, -2.5)]
        [DataRow(2, 234123512, -956459687, 7, -151332708)]
        [DataRow(3, 0, 0, 1, 0)]
        [DataRow(4, 2147483647, -2147483648, 2, -0.5)]
        public void ProcessSequence_ValidSequence_ReturnsCorrectStatistics(int testCaseNumber, int expectedMaxValue, int expectedMinValue, int expectedNumberOfElements, double expectedAverageValue)
        {
            // Act
            SequenceProcessingStatistics statistics = this.sequenceProcessor.ProcessSequence(this.testCases[testCaseNumber]);

            // Assert
            Assert.AreEqual(expectedMaxValue, statistics.MaxValue);
            Assert.AreEqual(expectedMinValue, statistics.MinValue);
            Assert.AreEqual(expectedNumberOfElements, statistics.NumberOfElements);
            Assert.IsTrue(Math.Abs(statistics.AverageValue - expectedAverageValue) < 0.0001);
        }
    }
}

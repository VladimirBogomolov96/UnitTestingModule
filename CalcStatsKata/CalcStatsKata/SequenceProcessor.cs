using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStatsKata
{
    public class SequenceProcessor
    {
        public SequenceProcessingStatistics ProcessSequence(IEnumerable<int> sequence)
        {
            if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "sequence should be not null");
            }

            if (sequence.Count() is 0)
            {
                throw new ArgumentException("sequence should has at least 1 item", nameof(sequence));
            }

            SequenceProcessingStatistics result = new SequenceProcessingStatistics() { MaxValue = int.MinValue, MinValue = int.MaxValue };
            double sumOfElements = 0;

            foreach (int num in sequence)
            {
                if (num > result.MaxValue)
                {
                    result.MaxValue = num;
                }

                if (num < result.MinValue)
                {
                    result.MinValue = num;
                }

                result.NumberOfElements++;
                sumOfElements += num;
            }

            result.AverageValue = sumOfElements / result.NumberOfElements;

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSumKata
{
    public class StringSumUtility
    {
        public string Sum(string num1, string num2)
        {
            int number1, number2;
            if (!int.TryParse(num1, out number1))
            {
                number1 = 0;
            }

            if (!int.TryParse(num2, out number2))
            {
                number2 = 0;
            }

            return (number1 + number2).ToString();
        }
    }
}

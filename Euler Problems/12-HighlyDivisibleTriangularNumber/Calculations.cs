using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangularNumber
{
    class Calculations
    {
        public void test()
        {
            int factors = 0;
            long number = 0;
            int index = 1;
            while (factors != 500)
            {
                number = Next(number, index);
                index++;
                factors = FindFactors(number);
            }
            Console.WriteLine(number);
        }

        private long Next(long number, int index)
        {
            number += index;
            return number;
        }

        private int FindFactors(long number)
        {
            long temp = 1;
            int amount = 0;
            while (temp <= number / 2)
            {
                if (number % temp == 0)
                {
                    amount++;
                }
                temp++;
            }
            amount++;
            return amount;
        }
    }
}

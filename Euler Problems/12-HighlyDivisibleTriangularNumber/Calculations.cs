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
            int lastFactors = 0;
            while (factors <= 500)
            {
                number += index;
                index++;
                factors = FindFactors(number);
                if (factors > lastFactors)
                {
                    lastFactors = factors;
                    Console.WriteLine(lastFactors);
                }
            }
            Console.WriteLine(number);
        }

        private int FindFactors(long number)
        {
            int amount = 0;
            for (long i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    amount++;
                    if (i != number / i)
                    {
                        amount++;
                    }
                }
            }
            return amount;
        }
    }
}

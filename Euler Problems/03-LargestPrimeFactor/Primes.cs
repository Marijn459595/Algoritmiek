using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Primes
    {
        public void FindPrimes(long number)
        {
            while (number % 2 == 0)
            {
                Console.Write("2 ");
                number /= 2;
            }

            for (int div = 3; div <= Math.Sqrt(number); div += 2)
            {
                while (number % div == 0)
                {
                    Console.Write(div + " ");
                    number /= div;
                }
            }
            if (number > 2)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("");
            Console.WriteLine(number);
        }
    }
}

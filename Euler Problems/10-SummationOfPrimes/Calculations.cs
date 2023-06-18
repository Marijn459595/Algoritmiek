using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfPrimes
{
    class Calculations
    {
        public void calculate()
        {
            long total = 2;
            int TwoMil = 1;
            while (TwoMil < 2000000)
            {
                TwoMil+= 2;
                if (PrimeCheck(TwoMil) == true)
                {
                    total += TwoMil;
                }
            }
            Console.WriteLine(total);
        }

        private bool PrimeCheck(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                int i = 3;
                int half = number / 2;
                while (i <= half)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                    i += 2;
                }
                return true;
            }
        }
    }
}

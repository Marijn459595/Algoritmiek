using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Calculations
    {
        public void Prime()
        {
            int number = 1;
            int prime = 0;
            while (prime != 10001)
            {
                number++;
                if (PrimeCheck(number) == true)
                {
                    prime++;
                }
            }
            Console.WriteLine(number);
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

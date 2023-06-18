using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPythagoreanTriplet
{
    class Calculations
    {
        public void calculate()
        {
            bool Correct = false;
            long a = 1;
            long b = 1;
            while (a < 333 && Correct == false)
            {
                a++;
                b = a;
                while(b < 1000 - a && Correct == false)
                {
                    b++;
                    if (SquareSum(a, b, 1000 - a - b) == true)
                    {
                        Correct = true;
                    }
                }
            }

            Console.WriteLine(a * b * (1000 - a - b));
        }

        private bool SquareSum(long a, long b, long c)
        {
            if (Square(a) + Square(b) == Square(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private long Square(long number)
        {
            return Convert.ToInt64(Math.Pow(number, 2));
        }
    }
}

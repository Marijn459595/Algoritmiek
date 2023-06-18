using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Calculations
    {
        public void Calc()
        {
            double total = SumSquare() - SquareSum();

            Console.WriteLine(total);
        }

        private double SquareSum()
        {
            double total = 0;
            for(int i = 1; i <= 100; i++)
            {
                total += Square(i);
            }
            return total;
        }

        private double SumSquare()
        {
            double total = 0;
            for (int i = 1; i <= 100; i++)
            {
                total += i;
            }
            return Square(total);
        }

        private double Square(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}

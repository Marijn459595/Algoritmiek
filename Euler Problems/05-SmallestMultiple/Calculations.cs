using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Calculations
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

        public void SmallestMultiple()
        {
            int multiple = 2520;
            bool answer = false;
            while (answer == false)
            {
                bool divisible = true;
                int i = 1;
                while (i < 20)
                {
                    if (multiple % i != 0)
                    {
                        divisible = false;
                    }
                    i++;
                }
                if (divisible == false)
                {
                    multiple += 20;
                }
                else
                {
                    answer = true;
                }
            }
            Console.WriteLine(multiple);
        }
    }
}

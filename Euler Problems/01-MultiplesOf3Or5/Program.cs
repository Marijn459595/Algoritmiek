﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.

        static void Main(string[] args)
        {
            FindMultiples Functions = new FindMultiples();

            Functions.FindSum();
            
            Console.ReadKey();
        }
    }
}

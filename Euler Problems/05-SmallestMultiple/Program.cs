﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            Calculations Calc = new Calculations();

            Calc.SmallestMultiple();

            Console.ReadKey();
        }
    }
}

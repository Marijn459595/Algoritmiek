﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindromes Palindromes = new Palindromes();

            Palindromes.FindLargestPalindrome();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Palindromes
    {
        public void FindLargestPalindrome()
        {
            int first;
            int second;
            int longest = 0;
            for (first = 1; first <= 999; first++)
            {
                for (second = 1; second <= 999; second++)
                {
                    int product = first * second;
                    string reversed = reverse(product);
                    if (reversed == product.ToString() && product > longest)
                    {
                        longest = product;
                        Console.WriteLine(first + " " + second);
                    }
                }
            }
            Console.WriteLine(longest);
        }

        private string reverse(int number)
        {
            char[] regular = number.ToString().ToCharArray();
            string reverse = String.Empty;
            for (int i = regular.Length - 1; i > -1; i--)
            {
                reverse += regular[i];
            }
            return reverse;
        }
    }
}

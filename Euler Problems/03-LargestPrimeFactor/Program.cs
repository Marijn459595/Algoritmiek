using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes Primes = new Primes();

            Primes.FindPrimes(600851475143);

            Console.ReadKey();
        }
    }
}

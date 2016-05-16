using System;
using System.Numerics;

namespace P08_CatalanNumbers
{
    class YouAreInsane
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(2*n)/(factorial(n+1)*factorial(n)));
        }

        static BigInteger factorial(int input)
        {
            BigInteger factK = 1;
            for (int i = 2; i <= input; i++)
            {
                factK *= i;
            }
            return factK;
        }
    }
}

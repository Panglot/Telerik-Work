using System;
using System.Numerics;

namespace P07_CalculateThree
{
    class PleaseStopTheCalcs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(n)/(factorial(k)*factorial(n-k)));
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

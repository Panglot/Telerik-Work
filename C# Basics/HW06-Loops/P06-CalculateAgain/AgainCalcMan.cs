using System;
using System.Numerics;

namespace P06_CalculateAgain
{
    class AgainCalcMan
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger factN = 1;
            for (int i = 2; i <= n; i++)
            {
                factN *= i;
            }

            BigInteger factK = 1;
            for (int i = 2; i <= k; i++)
            {
                factK *= i;
            }
            Console.WriteLine(factN / factK);
        }
    }
}


using System;
using System.Numerics;

namespace P03_Maslan
{
    class AslanWithM
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            int product = 1;
            int transformations = 0;
            for (;;)
            {
                input /= 10;
                if (input == 0)
                {
                    if (product / 10 > 0)
                    {
                        input = product;
                        transformations++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < input.ToString().Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        product *= (int)(input / BigInteger.Parse(Math.Pow(10, i).ToString()) % 10);
                    }
                }
            }
            Console.WriteLine(transformations);
            Console.WriteLine(input);
        }
    }
}

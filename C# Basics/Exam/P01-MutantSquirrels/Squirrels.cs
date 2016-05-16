using System;
using System.Numerics;

namespace P01_MutantSquirrels
{
    class Squirrels
    {
        static void Main(string[] args)
        {
            double trees = double.Parse(Console.ReadLine());
            double branches = double.Parse(Console.ReadLine());
            double squirrles = double.Parse(Console.ReadLine());
            double tails = double.Parse(Console.ReadLine());

            double result = trees * branches * squirrles * tails;

            if (result%2==0)
            {
                //BigInteger a = result * 376439;
                Console.WriteLine("{0:F3}", result*376439);
            }
            else
            {
                //double a = double.Parse(result.ToString()) / 7;
                Console.WriteLine("{0:F3}", result/7);
            }
        }
    }
}

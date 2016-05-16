using System;

namespace P05_Calculate
{
    class FkinCalcsMan
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            double inputDenom = double.Parse(Console.ReadLine());
            double sum = 0;

            for (uint i = 0; i <= inputNum; i++)
            {
                sum += (double)factorial(i) / Math.Pow(inputDenom, i);
            }

            Console.WriteLine("{0:F5}", sum);

        }

        static ulong factorial(uint input)
        {
            ulong fact = 1;
            for (ulong i = 2; i <= input; i++)
            {
                fact =fact * i;
            }

            return fact;
        }
    }
}

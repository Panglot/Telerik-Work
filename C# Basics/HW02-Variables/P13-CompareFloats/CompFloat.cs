using System;

namespace P12_CompareFloats
{
    class CompFloat
    {
        static void Main(string[] args)
        {

            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (Math.Abs(first - second) >= eps)
                Console.WriteLine("false");
            else
                Console.WriteLine("true");


        }
    }
}

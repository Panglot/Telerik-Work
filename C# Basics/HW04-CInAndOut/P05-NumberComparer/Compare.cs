using System;

namespace P04_NumberComparer
{
    class Compare
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(first, second));
        }
    }
}

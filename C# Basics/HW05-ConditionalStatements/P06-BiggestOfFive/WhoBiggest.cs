using System;

namespace P05_BiggestOfFive
{
    class WhoBiggest
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            double fifth = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(first, second), third),fourth),fifth));
        }
    }
}

using System;

namespace P01_ExchangeIfGreater
{
    class Exchange
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(first,second) + " "+ Math.Max(first, second));
        }
    }
}

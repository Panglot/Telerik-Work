using System;

namespace P05_BiggestOfThree
{
    class WhoBig
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(first,second),third));
        }
    }
}

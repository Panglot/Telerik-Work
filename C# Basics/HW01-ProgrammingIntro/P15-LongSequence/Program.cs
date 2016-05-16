using System;

namespace P15_LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                Console.WriteLine(i * Math.Pow(-1.0, (double)i));
            }
        }
    }
}

using System;

namespace P09_PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                Console.WriteLine(i*Math.Pow(-1.0, (double)i));
            }
        }
    }
}

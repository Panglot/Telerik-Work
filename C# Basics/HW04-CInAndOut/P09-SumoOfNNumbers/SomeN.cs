using System;

namespace P09_SumoOfNNumbers
{
    class SomeN
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double sum =0;
            for (int i = 0; i < input; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}

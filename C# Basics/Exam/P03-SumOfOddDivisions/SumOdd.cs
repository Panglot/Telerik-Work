using System;

namespace P03_SumOfOddDivisions
{
    class SumOdd
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int number = first; number <= second; number++)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0 && i % 2 != 0)
                    {
                        sum += i;
                    }

                }
            }
            Console.WriteLine(sum);
        }
    }
}

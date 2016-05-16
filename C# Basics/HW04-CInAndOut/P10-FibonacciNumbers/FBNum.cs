using System;

namespace P10_FibonacciNumbers
{
    class FBNum
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long current = 1;
            long oneBack = 1;
            string output = "0";
            for (long i = 1; i < input; i++)
            {
                output += ", " + current;
                if (i == 1)
                {
                    continue;
                }
                long temp = current;
                current = oneBack + current;
                oneBack = temp;

            }
            Console.WriteLine(output);

        }
    }
}
using System;

namespace P08_NumbersFromOneToN
{
    class NumMachine
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

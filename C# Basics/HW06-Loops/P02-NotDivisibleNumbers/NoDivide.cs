using System;

namespace P02_NotDivisibleNumbers
{
    class NoDivide
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (i%7!=0 && i%3!=0)
                {
                    if (i==input)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    Console.Write(i+" ");
                }
            }
        }
    }
}

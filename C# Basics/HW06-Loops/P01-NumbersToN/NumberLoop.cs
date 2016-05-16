using System;

namespace P01_NumbersToN
{
    class NumberLoop
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
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

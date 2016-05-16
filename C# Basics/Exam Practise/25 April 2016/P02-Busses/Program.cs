using System;

namespace P02_Busses
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int chainStart = int.Parse(Console.ReadLine());
            int groups =1;

            for (int i = 1; i < input; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                if (chainStart>=temp)
                {
                    groups++;
                    chainStart = temp;
                }
            }
            Console.WriteLine(groups);
        }
    }
}

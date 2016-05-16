using System;

namespace P15_GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int greater = Math.Max(int.Parse(input.Split(' ')[0]), int.Parse(input.Split(' ')[1]));
            int lower = Math.Min(int.Parse(input.Split(' ')[0]), int.Parse(input.Split(' ')[1]));
            int temp = 0;
            for (;;)
            {
                temp = greater % lower;
                greater = lower;
                lower = temp;
                if (lower==0)
                {
                    break;
                }
            }
            Console.WriteLine(greater);

        }
    }
}

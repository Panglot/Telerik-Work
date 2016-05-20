using System;

namespace P04_AppearanceCount
{
    class Counting
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string arr = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            count(size, arr, number);

        }
        static void count (int size, string arr, int number)
        {
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                if (int.Parse(arr.Split(' ')[i])==number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

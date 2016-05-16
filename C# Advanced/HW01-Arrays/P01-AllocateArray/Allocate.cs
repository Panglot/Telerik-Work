using System;

namespace P01_AllocateArray
{
    class Allocate
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int[] numbers = new int[input];

            for (int i = 0; i < input; i++)
            {
                numbers[i] = 5 * i;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press enter to start over.");
            Console.ReadLine();
            Console.Clear();
            Main();
            }
    }
}

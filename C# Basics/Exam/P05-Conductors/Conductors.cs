using System;

namespace P05_Conductors
{
    class Conductors
    {
        static void Main(string[] args)
        {
            int template = int.Parse(Console.ReadLine());
            int length = Convert.ToString(template, 2).Length;
            int cutter = 0;
            for (int i = 0; i < length; i++)
            {
                cutter = cutter << 1;
                cutter += 1;
            }
            int numbers = int.Parse(Console.ReadLine());
            int[] currNumber = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                currNumber[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < 32-length; j++)
                {
                    int compare = currNumber[i] & cutter<<j;
                    if (compare == template<<j)
                    {
                        currNumber[i] = currNumber[i] & ~(cutter << j);
                    }

                }
            }
            foreach (var item in currNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}

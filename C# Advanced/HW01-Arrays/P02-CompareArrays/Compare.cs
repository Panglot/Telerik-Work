using System;

namespace P02_CompareArrays
{
    class Compare
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] firstArray = new int[input];
            int[] secondArray = new int[input];

            for (int i = 0; i < input; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < input; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;

            for (int i = 0; i < input; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }


            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}

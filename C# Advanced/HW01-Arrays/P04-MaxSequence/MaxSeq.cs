using System;

namespace P04_MaxSequence
{
    class MaxSeq
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxLength = 1;
            int length = 1;
            int chainStart = 0;

            for (int i = 0; i < input; i++)
            {
                if (chainStart == arr[i])
                {
                    length++;
                }
                else
                {
                    if (length>maxLength)
                    {
                        maxLength = length;
                    }
                    chainStart = arr[i];
                    length = 1;
                }
            }

            if (length > maxLength)
            {
                maxLength = length;
            }
            Console.WriteLine(maxLength);

        }
    }
}

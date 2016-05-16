using System;

namespace P05_MaxIncreaseSequence
{
    class MaxIncSeq
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] arr = new int[input];

            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int previousElement =arr[0];
            int maxLength = 1;
            int length = 1;

            for (int i = 0; i < input; i++)
            {
                if (previousElement<arr[i])
                {
                    length++;
                    previousElement = arr[i];
                }
                else
                {
                    if (maxLength<length)
                    {
                        maxLength = length;
                    }
                    length = 1;
                    previousElement = arr[i];
                }

            }

            if (maxLength < length)
            {
                maxLength = length;
            }

            Console.WriteLine(maxLength);

        }
    }
}

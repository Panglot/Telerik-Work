using System;

namespace P02_Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] speed = new int[range];
            int chainStart = 5000;
            int largestLength = 1;
            int length = 1;


            for (int i = 0; i < range; i++)
            {
                speed[i] = int.Parse(Console.ReadLine());
            }

            int currSum = speed[0];
            int largestSum = speed[0];

            for (int i = 0; i < range; i++)
            {
                if (chainStart>=speed[i])
                {
                    if (length==largestLength && currSum>largestSum)
                    {
                        largestSum = currSum;
                    }
                    else if (length>largestLength)
                    {
                        largestLength = length;
                        largestSum = currSum;
                    }

                    length = 1;
                    chainStart = speed[i];
                    currSum = speed[i];
                }
                else
                {
                    length++;
                    currSum += speed[i];
                }
            }
            if (length == largestLength && currSum > largestSum)
            {
                largestSum = currSum;
            }
            else if (length > largestLength)
            {
                largestLength = length;
                largestSum = currSum;
            }

            Console.WriteLine(largestSum);
        }
    }
}

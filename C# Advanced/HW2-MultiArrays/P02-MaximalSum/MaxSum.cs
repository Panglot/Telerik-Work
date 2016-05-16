using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_MaximalSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split(' ')[0]);
            int columns = int.Parse(input.Split(' ')[1]);
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(currRow.Split(' ')[j]);
                }
            }

            int currSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < columns-2; j++)
                {
                    currSum = 0;
                    for (int k = i; k < 3+i; k++)
                    {
                        for (int l = j; l < 3+j; l++)
                        {
                            currSum += matrix[k, l];
                        }
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                    }
                }
            }
            if (currSum > maxSum)
            {
                maxSum = currSum;
            }

            Console.WriteLine(maxSum);
        }
    }
}

using System;

namespace P17_SpiralMatrix
{
    class Spiral
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int top = 0, left = 0;
            int bot = input-1, right = input-1;
            int row = 0, col = 0;
            string direction = "right";
            for (int i = 1; i <= input * input; i++)
            {
                if (direction == "right")
                {
                    matrix[row, col] = i;
                    if (col < right)
                    {
                        col++;
                    }
                    else
                    {
                        direction = "down";
                        row++;
                        top++;
                    }
                }
                else if (direction == "down")
                {
                    matrix[row, col] = i;
                    if (row < bot)
                    {
                        row++;
                    }
                    else
                    {
                        direction = "left";
                        col--;
                        right--;
                    }
                }
                else if (direction == "left")
                {
                    matrix[row, col] = i;
                    if (col > left)
                    {
                        col--;
                    }
                    else
                    {
                        direction = "up";
                        row--;
                        bot--;
                    }
                }
                else if (direction == "up")
                {
                    matrix[row, col] = i;
                    if (row > top)
                    {
                        row--;
                    }
                    else
                    {
                        direction = "right";
                        col++;
                        left++;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}

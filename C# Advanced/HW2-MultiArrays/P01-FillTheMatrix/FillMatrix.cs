using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_FillTheMatrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            switch (type)
            {
                case 'a':
                    matrixA(matrix, size);
                    break;
                case 'b':
                    matrixB(matrix, size);
                    break;
                case 'c':
                    matrixC(matrix, size);
                    break;
                case 'd':
                    matrixD(matrix, size);
                    break;

            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j + 1 != size)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void matrixA(int[,] matrix, int size)
        {
            int counter = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
        }

        static void matrixB(int[,] matrix, int size)
        {
            int counter = 1;
            bool odd = true;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (odd)
                    {
                        matrix[j, i] = counter;
                    }
                    else
                    {
                        matrix[size - 1 - j, i] = counter;
                    }
                    counter++;
                }
                odd = !odd;
            }
        }

        static void matrixC(int[,] matrix, int size)
        {
            int row = size-1, column = 0;
            int diagonal = 1;
            int counter = 1;

            for (int i = 1; i <= size*2 -1; i++)
            {
                for (int j = 0; j < diagonal; j++)
                {
                    matrix[row+j, column+j] = counter;
                    counter++;
                }
                if (i<size)
                {
                    row--;
                    diagonal++;
                }
                else
                {
                    column++;
                    diagonal--;
                }
            }
        }

        static void matrixD(int[,] matrix, int size)
        {

            int top = 0, left = 0;
            int bot = size - 1, right = size - 1;
            int row = 0, col = 0;
            string direction = "down";
            for (int i = 1; i <= size * size; i++)
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
                        direction = "up";
                        row--;
                        bot--;
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
                        direction = "right";
                        col++;
                        left++;
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
                        direction = "down";
                        row++;
                        top++;
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
                        direction = "left";
                        col--;
                        right--;
                    }
                }
            }
        }
    }
}

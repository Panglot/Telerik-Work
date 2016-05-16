using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SequenceMatrix
{
    class SeqMatrix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split(' ')[0]);
            int columns = int.Parse(input.Split(' ')[1]);
            int[,] matrix = new int[rows, columns];
            int maxNumber = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(currRow.Split(' ')[j]);
                    if (matrix[i,j]>maxNumber)
                    {
                        maxNumber = matrix[i, j];
                    }
                }
            }

            int counter = 0;
            int maxCounter = 0;
            int[] previousPos = new int[] { 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j]== maxNumber)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

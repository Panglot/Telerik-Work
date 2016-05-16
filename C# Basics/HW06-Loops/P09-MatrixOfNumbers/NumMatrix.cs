using System;

namespace P09_MatrixOfNumbers
{
    class NumMatrix
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = i; j <=input+i-1; j++)
                {
                    if (j==input+i-1)
                    {
                        Console.WriteLine(j);
                        break;
                    }
                    else
                    {

                        Console.Write(j + " ");
                    }
                }
            }

        }
    }
}

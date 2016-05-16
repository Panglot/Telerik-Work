using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class FallingRocks
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Engine();
            Console.WriteLine();
        }

        static void Engine()
        {
            char[,] field = new char[50, 50];
            field = start(field);
            display(field);


        }

        static void display (char[,] field)
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] start (char[,] field)
        {
            for (int i = 0; i < 40; i++)
            {
                char[] currRow = new char[50];
                currRow = generateRow();
                for (int j = 0; j < 50; j++)
                {
                    field[i, j] = currRow[j];
                }
            }
            for (int i = 40; i < 49; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    field[i, j] = ' ';
                }
            }
            for (int j = 0; j < 50; j++)
            {
                if (j==25)
                {
                    field[49, 25] = '@';
                    continue;
                }
                field[49, j] = ' ';
            }

            return field;
        }
        static char[] generateRow ()
        {
            char[] row = new char[50];
            Random rndm = new Random();

            for (int i = 0; i < 50; i++)
            {
                int rock = rndm.Next(0, 99);
                if (rock < 7)
                {
                    row[i] = 'o';
                }
                else if (rock< 14)
                {
                    row[i] = 'x';
                }
                else if (rock < 21)
                {
                    row[i] = 'a';
                }
                else if (rock < 28)
                {
                    row[i] = 'u';
                }
                else if (rock < 35)
                {
                    row[i] = 'e';
                }
                else
                {
                    row[i] = ' ';
                }
            }

            return row;
        }

    }
}

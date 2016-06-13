using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Porcupines
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseColumns = int.Parse(Console.ReadLine());
            int totalRows = int.Parse(Console.ReadLine());

            int[][] theField = generateField(baseColumns, totalRows);

            int[] rabbitPos = new int[2];
            rabbitPos = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rabbitScore = theField[rabbitPos[0]][rabbitPos[1]];
            theField[rabbitPos[0]][rabbitPos[1]] = 0;

            int[] porcPos = new int[2];
            porcPos = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int porcScore = theField[porcPos[0]][porcPos[1]];
            theField[porcPos[0]][porcPos[1]] = 0;




            for (; ; )
            {
                string currLine = Console.ReadLine();
                char[] commands = new char[3];
                if (currLine == "END")
                {
                    break;
                }
                else
                {
                    commands = currLine.Split(' ').Select(char.Parse).ToArray();
                }


                if (commands[0] == 'R')
                {
                    switch (commands[1])
                    {
                        case 'T':
                            rabbitPos[0] -= commands[2];
                            break;
                        case 'R':
                            rabbitPos[1] += positionFix('R', commands[2], rabbitPos, theField);
                            break;
                        case 'B':
                            rabbitPos[0] += commands[2];
                            break;
                        case 'L':
                            rabbitPos[1] += positionFix('L', commands[2], rabbitPos, theField);
                            break;
                    }

                    rabbitScore += theField[rabbitPos[0]][rabbitPos[1]];
                    theField[rabbitPos[0]][rabbitPos[1]] = 0;

                }

                else
                {
                    switch (commands[1])
                    {
                        case 'T':
                            for (int i = 1; i < commands[2] + 1; i++)
                            {
                                porcPos[0]--;
                                porcScore += theField[porcPos[0]][porcPos[1]];
                                theField[porcPos[0]][porcPos[1]] = 0;
                            }
                            break;
                        case 'R':
                            for (int i = 1; i < commands[2] + 1; i++)
                            {
                                porcPos[1] += positionFix('R', 1, porcPos, theField);
                                porcScore += theField[porcPos[0]][porcPos[1]];
                                theField[porcPos[0]][porcPos[1]] = 0;
                            }
                            break;
                        case 'B':
                            for (int i = 1; i < commands[2] + 1; i++)
                            {
                                porcPos[0]++;
                                porcScore += theField[porcPos[0]][porcPos[1]];
                                theField[porcPos[0]][porcPos[1]] = 0;
                            }
                            break;
                        case 'L':
                            for (int i = 1; i < commands[2] + 1; i++)
                            {
                                porcPos[1] += positionFix('R', 1, porcPos, theField);
                                porcScore += theField[porcPos[0]][porcPos[1]];
                                theField[porcPos[0]][porcPos[1]] = 0;
                            }
                            break;
                    }
                }


            }


            if (porcScore>rabbitScore)
            {
                Console.WriteLine("The porcupine destroyed the rabbit with {0} points. The rabbit must work harder. He scored {1} points only.", porcScore, rabbitScore);
            }
            else if (rabbitScore>porcScore)
            {
                Console.WriteLine("The rabbit WON with {0} points. The porcupine scored {1} points only.", rabbitScore, porcScore);
            }
            else
            {
                Console.WriteLine("Both units scored {0} points. Maybe we should play again?", porcScore);
            }
            //for (int i = 0; i < theField.Length; i++)
            //{
            //    for (int j = 0; j < theField[i].Length; j++)
            //    {
            //        Console.Write(theField[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


        }
        static int positionFix(char direction,int movement, int[] position, int[][] field)
        {
            int[] colRange = new int[] { 0, 0 };
            if (direction=='T' || direction=='B')
            {
                for (int i = 0; i < field.Length; i++)
                {
                    if (i<field[position[1]].Length)
                    {
                        
                    } 
                }
            }


            if (direction == 'L')
            {
                position[1] -= movement;
                if (position[1] < 0)
                {
                    for (; position[1] < 0; )
                    {
                        position[1] = field[position[0]].Length + position[1];
                    }
                }
                return position[1];
            }
            if (direction == 'R')
            {
                position[1] += movement;
                if (position[1] > field[position[0]].Length - 1)
                {
                    for (; position[1] > field[position[0]].Length - 1; )
                    {
                        position[1] = position[1] - field[position[0]].Length;
                    }

                }
                return position[1];
            }

            return 0;
        }

        static int[][] generateField(int baseCols, int rows)
        {
            int[][] field = new int[rows][];
            int indexation = -2;

            for (int i = 0; i < rows; i++)
            {
                int value = i + 1;
                if (i < rows / 2)
                {
                    field[i] = new int[baseCols * i + 2];
                    for (int j = 0; j < baseCols * i + 2; j++)
                    {
                        field[i][j] = value;
                        value += i + 1;
                    }

                }
                else
                {
                    field[i] = new int[baseCols * i + 2 + indexation];
                    for (int j = 0; j < baseCols * i + 2 + indexation; j++)
                    {
                        field[i][j] = value;
                        value += i + 1;
                    }
                    indexation -= 4;
                }


            }


            return field;
        }
    }
}

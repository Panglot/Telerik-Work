using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P02_Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder field = new StringBuilder();
            field.Append(Console.ReadLine());
            int[] moves = (Console.ReadLine()).Split(' ').Select(int.Parse).ToArray();

            int souls = 0;
            int food = 0;
            int deadlocks = 0;
            int jumps = -1;
            int position = 0;

            int i = -1;
            do
            {

                if (i >= 0)
                {
                    position += moves[i];
                    if (position < 0)
                    {
                        for (; position < 0; )
                        {
                            position = field.Length + position;
                        }
                    }
                    else if (position > field.Length - 1)
                    {
                        for (; position > field.Length - 1; )
                        {
                            position = position - field.Length;
                        }

                    }
                }

                jumps++;

                if (field[position] == '@')
                {
                    souls++;
                    field.Replace('@', ' ', position, 1);
                }
                else if (field[position] == '*')
                {
                    food++;
                    field.Replace('*', ' ', position, 1);
                }
                else if (field[position] == 'x')
                {
                    deadlocks++;
                    if (position % 2 == 0 && souls != 0)
                    {
                        souls--;
                    }
                    else if (position % 2 != 0 && food != 0)
                    {
                        food--;
                    }
                    else
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", jumps);
                        return;
                    }
                }
                i++;
            } while (i < moves.Length);


            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);
        }

    }
}

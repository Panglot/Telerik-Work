using System;

namespace P04_MalkoKote
{
    class Kote
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char catSymbol = char.Parse(Console.ReadLine());
            int dependancy = (input - 10) / 4 +1;
            int width = 2 + dependancy;

            Console.WriteLine(" " + catSymbol + new string(' ',dependancy) + catSymbol);
            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine(" "+new string(catSymbol, width));
            }
            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine("  " + new string(catSymbol, dependancy));
            }
            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine(" " + new string(catSymbol, width));
            }
            Console.WriteLine(" " + new string(catSymbol, width) + "   " + new string(catSymbol,dependancy+1));

            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(new string(catSymbol, width+2) + "  " + catSymbol);
            }
            Console.WriteLine(new string(catSymbol, width + 2) + " " + catSymbol+catSymbol);
            Console.WriteLine(" " + new string(catSymbol, 5+dependancy));
        }
    }
}

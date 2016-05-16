using System;

namespace P04_Batman
{
    class NananaBatman
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char batSymbol = char.Parse(Console.ReadLine());

            int dependancy = (input - 5) / 2 + 1;
            int outline = 0;

            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine(new string(' ', outline)+ new string(batSymbol,input-outline)+new string(' ', input)+new string(batSymbol, input-outline));
                outline++;
            }

            Console.WriteLine(new string(' ', outline) + new string(batSymbol, input - outline) + new string(' ', (input-3)/2) + "{0} {0}" + new string(' ', (input - 3) / 2) + new string(batSymbol, input - outline), batSymbol);
            outline++;


            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine(new string(' ', outline)+new string(batSymbol, (input-outline)*2 +input));
            }


            outline = input+1;
            input -= 2;


            for (int i = 0; i < dependancy; i++)
            {
                Console.WriteLine(new string(' ', outline) + new string(batSymbol, input));
                input -= 2;
                outline++;
            }

            Console.WriteLine(new string(' ', outline)+batSymbol);

        }
    }
}

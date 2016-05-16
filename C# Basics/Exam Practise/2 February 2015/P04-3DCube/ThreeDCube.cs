using System;

namespace P04_3DCube
{
    class ThreeDCube
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int middle = input - 2;

            Console.WriteLine(new string(':', input)); //Първи ред

            for (int i = 0; i < middle; i++)
            {
                Console.WriteLine(":" + new string(' ', middle) + ":" + new string('|', i) + ":");
            }

            Console.WriteLine(new string(':', input) + new string('|', middle) + ":");//Среден ред

            for (int i = 1; i <= middle; i++)
            {
                Console.WriteLine(new string(' ', i) + ":" + new string('-', middle) + ":" + new string('|', middle - i) + ":");
            }
                  
            Console.WriteLine(new string(' ', middle+1)+new string(':',input)); //Последен ред 
        }
    }
}

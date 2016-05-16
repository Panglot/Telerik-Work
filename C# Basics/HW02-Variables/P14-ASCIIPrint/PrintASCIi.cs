using System;

namespace P14_ASCIIPrint
{
    class PrintASCIi
    {
        static void Main(string[] args)
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}

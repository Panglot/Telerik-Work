using System;

namespace P03_CompareCharArrays
{
    class CompChar
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.CompareTo(second) ==0)
            {
                Console.WriteLine("=");
            }
            else if (first.CompareTo(second)==1)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}

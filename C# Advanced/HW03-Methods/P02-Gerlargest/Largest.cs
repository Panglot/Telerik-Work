using System;

namespace P02_Gerlargest
{
    class Largest
    {
        static void Main(string[] args)
        {
            GetMax(Console.ReadLine());
        }

        static void GetMax(string input)
        {
            Console.WriteLine(Math.Max(Math.Max(int.Parse(input.Split(' ')[0]), int.Parse(input.Split(' ')[1])), int.Parse(input.Split(' ')[2])));
        }
    }
}

using System;

namespace P02_MoonGravity
{
    class MonGrav
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}",weight *0.17);
        }
    }
}

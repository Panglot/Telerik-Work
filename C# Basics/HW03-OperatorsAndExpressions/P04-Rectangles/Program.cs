using System;

namespace P04_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} {1:F2}", (height * width), (2 * height + 2 * width));
        }
    }
}

using System;

namespace P09_Trapezoid
{
    class Trap
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F7}", (a+b)*h/2);

        }
    }
}

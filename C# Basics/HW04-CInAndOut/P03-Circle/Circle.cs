using System;

namespace P03_Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} {1:F2}",2*Math.PI*radius, Math.PI*radius*radius);
        }
    }
}

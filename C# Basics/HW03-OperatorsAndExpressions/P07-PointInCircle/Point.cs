using System;

namespace P07_PointInCircle
{
    class Point
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (Math.Pow(x,2) + Math.Pow(y,2) <= 4)
                Console.WriteLine("yes {0:F2}",distance);
            else
                Console.WriteLine("no {0:F2}",distance);
        }
    }
}

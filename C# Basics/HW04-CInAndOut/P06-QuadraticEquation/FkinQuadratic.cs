using System;

namespace P06_QuadraticEquation
{
    class FkinQuadratic
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double determinant = Math.Pow(b, 2) - 4 * a * c;

            if (determinant > 0)
            {
                double x1 = (b * (-1) + Math.Sqrt(determinant)) / (2 * a);
                double x2 = (b * (-1) - Math.Sqrt(determinant)) / (2 * a);
                if (x1>x2)
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);
                }
            }
            else if (determinant == 0)
            {
                Console.WriteLine("{0:F2}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}

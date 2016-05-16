using System;

namespace PointSomewhere
{
    class GoddamnedPoint
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if(Math.Pow((1-x),2)+Math.Pow((1-y),2)<=Math.Pow(1.5,2))
                Console.Write("inside circle ");
            else
                Console.Write("outside circle ");

            if(x>=-1&&x<=5&&y>=-1&&y<=1)
                Console.WriteLine("inside rectangle");
            else
                Console.WriteLine("outside rectangle");
        }
    }
}

using System;

namespace P04_MultiplicationSign
{
    class MultSign
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (first*second*third==0)
            {
                Console.WriteLine("0");
            }
            else if (first*second*third>0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

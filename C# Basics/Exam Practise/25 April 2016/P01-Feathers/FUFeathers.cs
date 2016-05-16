using System;

namespace P01_Feathers
{
    class FUFeathers
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            if (first%2==0)
            {
                Console.WriteLine("{0:F4}",second/first* 123123123123);
            }
            else 
            {
                Console.WriteLine("{0:F4}", (second / first)/317);
            }
        }
    }
}

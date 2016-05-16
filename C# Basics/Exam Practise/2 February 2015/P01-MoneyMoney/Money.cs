using System;

namespace P01_MoneyMoney
{
    class Money
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());


            Console.WriteLine("{0:F3}", (n*s)/400 * p);
        }
    }
}

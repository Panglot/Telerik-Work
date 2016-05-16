using System;

namespace P06_FourDigits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int d = input % 10;
            int c = input / 10 % 10;
            int b = input / 100 % 10;
            int a = input / 1000 % 10;
            Console.WriteLine(a+b+c+d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}

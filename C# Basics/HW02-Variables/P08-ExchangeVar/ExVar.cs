using System;

namespace P08_ExchangeVar
{
    class ExVar
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

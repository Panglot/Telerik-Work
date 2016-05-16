using System;

namespace P11_Nulls
{
    class Nulls
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a+"\n"+b);
            a = 4;
            b = 6.235;
            Console.WriteLine(a + "\n" + b);
        }
    }
}

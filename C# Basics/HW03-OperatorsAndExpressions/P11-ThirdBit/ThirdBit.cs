using System;

namespace P11_ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((a>>3)&1);

        }
    }
}

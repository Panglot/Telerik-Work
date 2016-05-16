using System;

namespace P12_NBit
{
    class Nbit
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            int bitCheck = int.Parse(Console.ReadLine());
            if (bitCheck > 32)
                Console.WriteLine(0);
            else
                Console.WriteLine((input >> bitCheck) & 1);
        }
    }
}

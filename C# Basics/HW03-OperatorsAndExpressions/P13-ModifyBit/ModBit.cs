using System;

namespace P13_ModifyBit
{
    class ModBit
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());

            if (v == 1)
            {
                Console.WriteLine(((ulong)1 << position) | input);
            }
            else
            {
                Console.WriteLine(~((ulong)1 << position) & input);
            }
        }
    }
}

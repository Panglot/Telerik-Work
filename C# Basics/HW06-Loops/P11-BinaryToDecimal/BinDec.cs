using System;

namespace P11_BinaryToDecimal
{
    class BinDec
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            ulong decNumber = 0;
            ulong hexCurrent = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='A')
                {
                    hexCurrent = 10;
                }
                else if (input[i] == 'B')
                {
                    hexCurrent = 11;
                }
                else if (input[i] == 'C')
                {
                    hexCurrent = 12;
                }
                else if (input[i] == 'D')
                {
                    hexCurrent = 13;
                }
                else if (input[i] == 'E')
                {
                    hexCurrent = 14;
                }
                else if (input[i] == 'F')
                {
                    hexCurrent = 15;
                }
                else
                {
                    hexCurrent = (ulong)char.GetNumericValue(input[i]);
                }
                decNumber += ((ulong)Math.Pow(16, i) * hexCurrent);
            }
            Console.WriteLine(decNumber);
        }
    }
}

using System;

namespace P13_DecimalToHex
{
    class DecHex
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            string binNumber = "";
            for (; input != 0;)
            {
                if (input%16<10)
                {
                    binNumber += input % 16;
                }
                else if (input%16==10)
                {
                    binNumber += "A";
                }
                else if (input % 16 == 11)
                {
                    binNumber += "B";
                }
                else if (input % 16 == 12)
                {
                    binNumber += "C";
                }
                else if (input % 16 == 13)
                {
                    binNumber += "D";
                }
                else if (input % 16 == 14)
                {
                    binNumber += "E";
                }
                else
                {
                    binNumber += "F";
                }
                input /= 16;
            }
            char[] reverse = binNumber.ToCharArray();
            Array.Reverse(reverse);

            Console.WriteLine(new string(reverse));
        }
    }
}

using System;

namespace P12_DecimalToBinary
{
    class DecBin
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string binNumber = "";
            for (;input!=0;)
            {
                binNumber += input % 2;
                input /= 2;
            }
            char[] reverse = binNumber.ToCharArray();
            Array.Reverse(reverse);

            Console.WriteLine(new string(reverse));
        }
    }
}

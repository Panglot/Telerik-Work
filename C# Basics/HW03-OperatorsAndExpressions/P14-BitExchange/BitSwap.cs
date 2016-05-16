using System;
using System.Text;

namespace P14_BitExchange
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');


            StringBuilder inputCopy = new StringBuilder(input);

            inputCopy[28] = input[7];
            inputCopy[27] = input[6];
            inputCopy[26] = input[5];
            inputCopy[7] = input[28];
            inputCopy[6] = input[27];
            inputCopy[5] = input[26];
            
            Console.WriteLine(Convert.ToInt32(inputCopy.ToString(), 2));



        }
    }
}

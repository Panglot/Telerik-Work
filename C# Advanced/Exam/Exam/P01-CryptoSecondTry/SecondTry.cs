using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P01_CryptoSecondTry
{
    class SecondTry
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            char sign = char.Parse(Console.ReadLine());
            string secondInput = Console.ReadLine();

            //char[] letterBased = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //char[] sevenBased = new char[] { '0', '1', '2', '3', '4', '5', '6' };
            char[] nineBased = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            string letterBased = "abcdefghijklmnopqrstuvwxyz";
            string sevenBased = "0123456";

            BigInteger firstNumber = ConvertFromBase(letterBased, firstInput);
            BigInteger secondNumber = ConvertFromBase(sevenBased, secondInput);
            BigInteger lastConversion = 0;

            if (sign == '+')
            {
                lastConversion = firstNumber + secondNumber;
            }
            else
            {
                lastConversion = firstNumber - secondNumber;
            }

            string result = "";
            do
            {
                result += lastConversion % 9;
                lastConversion /= 9;
            } while (lastConversion != 0);



            char[] forReverse = result.ToCharArray();
            Array.Reverse(forReverse);
            result = new string(forReverse);


            Console.WriteLine(result);

        }
        
        static BigInteger ConvertFromBase(string charset, string number)
        {
            return (BigInteger)(number.Select(c => charset.IndexOf(c)).Aggregate(0, (x, y) => x * charset.Length + y));
        }

        public static string IntToString(BigInteger value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[(int)(value % targetBase)] + result;
                value = value / targetBase;
            }
            while (value > 0);

            return result;
        }

        //static BigInteger toDec(string number, char[] theBase)
        //{
        //    BigInteger result = 0;
        //    int i = 0;
        //    do
        //    {
        //        BigInteger temp = Array.IndexOf(theBase, number[number.Length-1]);
        //        result += temp * (BigInteger)Math.Pow(theBase.Length, i);
        //        number = number.Remove(number.Length - 1);
        //        i++;
        //    } while (number.Length!=0);

        //    return result;
        //}
    }
}

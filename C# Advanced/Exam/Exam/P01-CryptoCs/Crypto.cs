using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P01_CryptoCs
{
    class Crypto
    {
        static void Main()
        {
            string charBase = Console.ReadLine();
            char symbol = char.Parse(Console.ReadLine());
            string secondBase = Console.ReadLine();


            List<char> bigBase = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> sevenBase = new List<char> {'0','1','2','3','4','5','6'};
           
            BigInteger firstnumber = 0;
            int i = 0;
            do
            {
                firstnumber += (BigInteger)(bigBase.IndexOf(charBase[charBase.Length-1]))*(BigInteger)Math.Pow(26, i);
                charBase = charBase.Remove(charBase.Length - 1);
                i++;
            } while (charBase.Length > 0);

            BigInteger secondnumber = 0;

            int j = 0;
            do
            {
                secondnumber += (BigInteger)(sevenBase.IndexOf(secondBase[secondBase.Length - 1])) * (BigInteger)Math.Pow(7, j);
                secondBase = secondBase.Remove(secondBase.Length - 1);
                j++;
            } while (secondBase.Length > 0);

            BigInteger combine = 0;

            if (symbol=='+')
            {
                combine = firstnumber + secondnumber;
            }
            else
            {
                combine = firstnumber - secondnumber;
            }        

            string result = "";
            do
            {
                result += (combine % 9).ToString();
                combine /= 9;
            } while (combine != 0) ;



            char[] forReverse = result.ToCharArray();
            Array.Reverse(forReverse);
            result = new string(forReverse);

            Console.WriteLine(result);            
        }

    }
}

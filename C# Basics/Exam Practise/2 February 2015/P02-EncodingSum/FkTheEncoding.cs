using System;

namespace P02_EncodingSum
{
    class FkTheEncoding
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int result = 0; 

            for (int i = 0 ; ; i++ )
            {               
                if (text[i] == '@')
                {
                    break;
                }

                else if (char.IsDigit(text[i]))
                {
                    result *= int.Parse(char.ToString(text[i]));
                }
                else if (char.IsLetter(text[i]))
                {
                    result += (int)char.ToUpper(text[i]) -65;
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}

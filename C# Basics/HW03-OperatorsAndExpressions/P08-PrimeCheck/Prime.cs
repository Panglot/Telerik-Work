using System;

namespace P08_PrimeCheck
{
    class Prime
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number == 1 || number==0)
            {
                Console.WriteLine("false");
                return;
            }

            for(int i = Math.Abs(number-1);i>1;i--)
            {
                if(number%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            
                Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}

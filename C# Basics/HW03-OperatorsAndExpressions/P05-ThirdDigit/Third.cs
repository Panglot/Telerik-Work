using System;

namespace P05_ThirdDigit
{
    class Third
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()); 
            if((input/100)%10==7)
                Console.WriteLine("true");
            else
                Console.WriteLine("false {0}",(input/100)%10);
        }
    }
}

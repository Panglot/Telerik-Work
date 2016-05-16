using System;

namespace P03_DivideBy
{
    class Divide
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if(input%5==0 && input%7==0)
                Console.WriteLine("true {0}", input);
            else
                Console.WriteLine("false {0}",input);     
        }
    }
}

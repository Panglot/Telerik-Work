using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (Math.Abs(a%2)==1)
                Console.WriteLine("odd " + a);
            else 
                Console.WriteLine("even " +a);
        }
    }
}

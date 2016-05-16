using System;

namespace P03_NumberOfPages
{
    class GetThePages
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int i = 0;
            for (; input > 0; )
            {
                i++;
                input -= i.ToString().Length;
            }
            Console.WriteLine(i);
        }
    }
}

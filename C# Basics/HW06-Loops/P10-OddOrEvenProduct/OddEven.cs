using System;

namespace P10_OddOrEvenProduct
{
    class OddEven
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            ulong oddProduct = 1;
            ulong evenProduct = 1;

            for (ulong i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= ulong.Parse(input[i]);
                }
                else
                {
                    oddProduct *= ulong.Parse(input[i]);
                }
            }
            if (evenProduct==oddProduct)
            {
                Console.WriteLine("yes {0}",evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}",evenProduct, oddProduct);
            }

        }
    }
}

using System;

namespace P07_SortThree
{
    class YUNoSort
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            

            Console.Write(Math.Max(first, Math.Max(second, third))+ " ");

            if (Math.Max(first, Math.Max(second, third)) == first)
            {
                Console.Write(Math.Max(second,third)+" ");
                Console.WriteLine(Math.Min(second,third));
            }
            else if (Math.Max(first, Math.Max(second, third)) == second)
            {
                Console.Write(Math.Max(first, third) + " ");
                Console.WriteLine(Math.Min(first, third));
            }
            else
            {

                Console.Write(Math.Max(first, second) + " ");
                Console.WriteLine(Math.Min(first, second));
            }


        }
    }
}

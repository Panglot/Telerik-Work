using System;
using System.Text;

namespace P15_BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Convert.ToString(int.Parse(Console.ReadLine()),2).PadLeft(32,'0');
            int first = 31-int.Parse(Console.ReadLine());
            int second = 31-int.Parse(Console.ReadLine());
            int interval = int.Parse(Console.ReadLine());
            StringBuilder inputCopy = new StringBuilder(input);

            for (int i = 0; i < interval; i++)
            {
                inputCopy[first] = input[second];
                inputCopy[second] = input[first];
                first--;
                second--;
            }
            Console.WriteLine(Convert.ToInt32(inputCopy.ToString(), 2));

        }
    }
}

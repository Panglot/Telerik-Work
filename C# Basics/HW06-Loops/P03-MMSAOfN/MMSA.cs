using System;

namespace P06_MMSAOfN
{
    class MMSA
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double first = double.Parse(Console.ReadLine());
            double min = first;
            double max = first;
            double sum = first;
            double avg = first;
            double second = 0;

            for (int i = 1; i < length; i++)
            {
                second = double.Parse(Console.ReadLine()); 
                min = Math.Min(min, second);
                max = Math.Max(max, second);
                sum += second;
                avg = sum / (i+1);
            }


            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}

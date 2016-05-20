using System;

namespace P06_FirstLarger
{
    class Larger
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string arr = Console.ReadLine();
            large(size, arr);
        }
        static void large(int size, string arr)
        {
            int result = -1;
            for (int i = 0; i < size; i++)
            {
                if (i!=0&& i+1!=size&& int.Parse(arr.Split(' ')[i])> int.Parse(arr.Split(' ')[i+1]) & int.Parse(arr.Split(' ')[i]) > int.Parse(arr.Split(' ')[i -1]))
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

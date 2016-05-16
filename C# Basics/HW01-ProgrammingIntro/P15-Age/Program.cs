using System;

namespace P15_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int output = (int)(DateTime.Now.Subtract(birthday).TotalDays / 365.242199);
            Console.WriteLine("{0}\n{1}",output,output+10);
            Console.WriteLine(DateTime.Now.Subtract(birthday).TotalDays);
        }
    }
}

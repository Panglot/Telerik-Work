using System;

namespace P09_IntDoubleString
{
    class SomeTypes
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "text")
            {
                Console.WriteLine(Console.ReadLine() + "*");
            }
            else if (type == "integer")
            {
                Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
            }
            else
            {
                Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) + 1);
            }
        }
    }
}

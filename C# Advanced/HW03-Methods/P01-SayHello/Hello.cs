using System;

namespace P01_SayHello
{
    class Hello
    {
        static void Main(string[] args)
        {
            hi(Console.ReadLine());
        }

        static void hi(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}

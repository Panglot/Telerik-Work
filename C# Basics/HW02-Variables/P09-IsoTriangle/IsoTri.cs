using System;

namespace P08_IsoTriangle
{
    class IsoTri
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char c = '\u00A9';
            Console.WriteLine("   {0}",c);
            Console.WriteLine("  {0} {0}",c);
            Console.WriteLine(" {0}   {0}",c);
            Console.WriteLine("{0} {0} {0} {0}",c);
        }
    }
}

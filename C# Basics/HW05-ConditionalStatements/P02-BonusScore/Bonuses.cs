using System;

namespace P02_BonusScore
{
    class Bonuses
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input>=1 && input<=3)
            {
                Console.WriteLine(input*10);
            }
            else if (input >=4 && input<=6)
            {
                Console.WriteLine(input*100);
            }
            else if (input>=7 && input<=9)
            {
                Console.WriteLine(input*1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}

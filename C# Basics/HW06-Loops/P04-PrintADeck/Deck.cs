using System;

namespace P04_PrintADeck
{
    class Deck
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int interations = 0;

            if (input == "J")
            {
                interations = 11;
            }
            else if (input == "Q")
            {
                interations = 12;
            }
            else if (input == "K")
            {
                interations = 13;
            }
            else if (input == "A")
            {
                interations = 14;
            }
            else
            {
                interations = int.Parse(input);
            }


            for (int i = 2; i <= interations; i++)
            {

                if (i == 11)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                }
                else if (i == 12)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                }
                else if (i == 13)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                }
                else if (i == 14)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
                }
                else
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
        }
    }
}

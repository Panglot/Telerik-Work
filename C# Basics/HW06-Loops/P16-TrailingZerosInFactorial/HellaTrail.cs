using System;

class HelaTrail
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());


        int zeroes = 0;

        for (int power5 = 5; power5 <= input; power5 *= 5)
        {
            zeroes += input / power5;
        }

        Console.WriteLine(zeroes);
    }
}
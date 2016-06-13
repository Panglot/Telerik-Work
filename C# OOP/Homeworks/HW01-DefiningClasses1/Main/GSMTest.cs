namespace Main
{
    using GSMClasses;
    using GSMClasses.Features;
    using GSMClasses.Components;
    using System;

    class GSMTest // Не разбирам защо трябва да правя отделен клас за да тествам и Историята на повикванията,
                  // тъй че предоставям тест за GSM-ите и за повикванията в този клас и директно в Main метода.
    {
        static void Main(string[] args)
        {
            //GSM Test
            GSM[] arrayOfGSM = new GSM[3];
            arrayOfGSM[0] = new GSM("Iphone3", "Apple");
            arrayOfGSM[1] = new GSM("Iphone4", "Apple", 123.99m, new Battery(BatteryType.LiIon, 12, 6), new Display(3.5, 16000000));
            arrayOfGSM[2] = new GSM("Iphone5", "Apple", 259.99m, new Battery(BatteryType.LiIon, 16, 8), new Display(4, 16250000), "Ivan Petrov");


            Console.WriteLine("GSM Test\n");
            foreach (var item in arrayOfGSM)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("Static IPhone 4S");
            Console.WriteLine(GSM.IPhone4S + "\n\n");

            //Call History Test. Директно върху първият GSM от горния масив.

            arrayOfGSM[0].AddCall(new Call("14 February", "14:32", "0886512348", 148));
            arrayOfGSM[0].AddCall(new Call("2 June", "08:32", "0881232348", 287));
            arrayOfGSM[0].AddCall(new Call("27 December", "22:05", "0886512681", 35));

            Console.WriteLine("Calls History Test\n");
            foreach (var item in arrayOfGSM[0].CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Calls Price: " + arrayOfGSM[0].CallsPrice(0.37m) + " euro.");

            Console.WriteLine("Finding and removing the longest call...");
            uint biggestDuration = 0;
            int elementNumber = 0;
            for (int i = 0; i < arrayOfGSM[0].CallHistory.Count; i++)
            {
                if (arrayOfGSM[0].CallHistory[i].Duration > biggestDuration)
                {
                    biggestDuration = arrayOfGSM[0].CallHistory[i].Duration;
                    elementNumber = i;
                }
            }
            arrayOfGSM[0].DeleteCall(elementNumber);

            Console.WriteLine("Calls Price after the removal: " + arrayOfGSM[0].CallsPrice(0.37m) + " euro.\n");

            Console.WriteLine("Clearing the call history...");
            arrayOfGSM[0].ClearCalls();
            Console.WriteLine("Displaying that clear works:");
            foreach (var item in arrayOfGSM[0].CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

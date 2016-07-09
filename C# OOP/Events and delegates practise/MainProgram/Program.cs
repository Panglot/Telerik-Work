namespace MainProgram
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            EventfulList<int> testList = new EventfulList<int>(); // Creating instace of our class.

            // This is where we subscribe for the ven of our class. Since customEventForChange is
            // public we can access it. As delegate it allows us to add methods to it.
            // We add our method OnChange. It must have the signature of EventHandler which is
            // return type void and arguments (object, EventArgs). Since we attached our method
            // every time the class raises the event our method will be invoked. This way we are
            // subscribed for the event and can do something every time its raised.
            testList.customEventForChange += OnChange; 

            testList.Add(5);
            testList.Add(2);
            testList.Add(15);
            testList.Clear();

            Console.WriteLine();


            EventfulList<int> testList2 = new EventfulList<int>(); // Second instance just for the example.

            testList2.customEventForChange += OnChange;

            testList2.Add(5);
            testList2.Add(2);
            testList2.Add(15);
            testList2.Clear();


        }

        // This is the method we subscribe (attach) to the event. Notice that it has the same signature
        // as the event delegate: void return type and arguments (object, EventArgs). Every time the event
        // is raised, this method will be invoked. In this case we just print stuff on the console to show
        // that its working, but we can do whatever we want. 
        static void OnChange(object sender, EventArgs args)
        {
            Console.WriteLine("Event tracks for list changes. List {0} has been changed!", sender.GetHashCode());
        }
    }
}

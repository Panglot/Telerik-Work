namespace MainProgram
{
    using System;
    using System.Collections.Generic;

    class EventfulList<T>
    {
        // The keyword event says its an event. EventHandler is predefined delegate.
        // It should be public so subscribers can access it.
        // We can create our own delegate with the same signature.
        // public delegate void ChangedEventHandler(object sender, EventArgs e);
        // and then again create instance of our delegate
        // public event ChangedEventHandler customEventForChange;
        public event EventHandler customEventForChange; 

        private List<T> data;

        public EventfulList()
        {
            this.data = new List<T>();
        }

        // OnChange is our method that can be named as we want. The convention is On[event]
        // The method "raises" the event. By raises means that it invokes all the methods
        // attached to our EventHandle delegate. Every time you call this mehtod it tries
        // to invoke all the methods attached. It doesnt care who or what is attached.
        // This is loose coupling. This class has no connection to any other class, while
        // any other class can attach to its event.
        private void OnChange()
        {
            if (customEventForChange != null)
            {
                customEventForChange.Invoke(this, EventArgs.Empty);
            }
        }

        public void Add(T value)
        {
            data.Add(value);
            // Here we raise the event. We say "Something happened. Whoever is attached
            // should know about it. Do your stuff!".
            this.OnChange(); 
        }

        public void Clear()
        {
            data.Clear();
            this.OnChange(); // We raise the event again.
        }

    }
}

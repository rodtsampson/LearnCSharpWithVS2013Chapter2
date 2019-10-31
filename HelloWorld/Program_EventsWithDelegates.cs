using System;

namespace EventsWithDelegates
{
    public delegate void ChangedEventHandler();
    class EventsExample
    {
        //declares event
        public static event ChangedEventHandler windowChanged;
        public static void ChangeWindowSize(int height)
        {
            // add event handler
            //attach event handler to event
            windowChanged += ShowEventMessage;
            windowChanged.Invoke();
        }
        public static void ShowEventMessage()
        {
            Console.WriteLine("Window Resized");
        }
        //static void Main()
        //{
        //    //read the line
        //    //call Change window size
        //    //invokes the event with the message
        //    EventsExample.ChangeWindowSize(int.Parse(Console.ReadLine()));
        //}
    }
}
namespace Class06
{
    // This delegate will handle the event
    public delegate void Notify(string message);

    public class EventPublisher
    {
        // The "On" prefix makes it immediately clear that the method is associated with an event. 
        // It signifies that the method is not just a regular method but one that is called when a specific event occurs.
        public event Notify OnNotify;

        // Raising an event means that you are basically starting the event.
        public void RaiseEvent(string message)
        {
            // It will invoke all of the subscribers that are listening to 'OnNotify'.
            OnNotify?.Invoke(message); // Invoke the event only if there are any subscribers.
            Console.WriteLine("Invoked.");
        }
    }

    // That is a subscriber to our event.
    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;

            // Raising the event.
            publisher.RaiseEvent("test");

            Console.ReadKey();
        }
    }
}

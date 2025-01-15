

namespace Class01
{
    // 1. Declaration:
    public delegate void Notify(string message);

    internal class Program
    {   
        static void Main(string[] args)
        {
            // Delegates define a method signature, and any method assigned to a delegate must match this signature.

            // 2. Instatiation:
            // There are two ways to instatiating a delegate:
            Notify notifyDelegate = ShowMessage; // Assigning a method to the delegate that matchs with the delegate signature.
            // Notify notifyDelegate = new Notify(ShowMessage); // OLD WAY ONE


            // 3. Invocation:
            notifyDelegate("Hello, world!");

            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

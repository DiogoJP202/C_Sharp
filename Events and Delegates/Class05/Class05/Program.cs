namespace Class05
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            // Creating a multicast delegate:
            LogHandler logHandler = logger.LogToConsole;
            // This '+=' is just saying 'add to the old method that is already in there, this other one'. 
            logHandler += logger.LogToFile;

            // Invoking the multicast delegate:
            InvokeSafely(logHandler, "Log this info.");

            // 'GetInvocationList' method will give us the items inside of the delegate. It'll return an array of delegates.
            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }

            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                // Removing a method:
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method was removed.");
            }
            else
                Console.WriteLine("LogToFile method not found.");

            InvokeSafely(logHandler, "After removing a file.");

            Console.ReadKey();
        }

        // Invoking our delegate more safely.
        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
                tempLogHandler(message);
            else
                Console.WriteLine("Error in execute the multicast delegate.");
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
                return false;
            foreach(var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate) method)
                    return true;
            }
            return false;
        }
    }
}

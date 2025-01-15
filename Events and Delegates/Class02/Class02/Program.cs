namespace Class02
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
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console.");
            
            logHandler = logger.LogToFile;
            logHandler("Log some stuff.");

            Console.ReadKey();
        }
    }
}

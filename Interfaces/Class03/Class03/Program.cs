namespace Class03
{
    public interface ILogger
    {
       void Log(string message);
    }

    public class FileLogger 
        : ILogger
    {
        public void Log(string message)
        {
            // Creating a file and appending a text into it.
            try
            {
                // You can use the "@" at the beginning of a string to use '\' without using a escape character.
                // The "@" sign is C# is used to denote a verbatim string literal.
                string directoryPath = @"C:\Logs";

                // Concatenating paths.
                string filePath = Path.Combine(directoryPath, "log.txt");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Creating a file and appeding a text into it.
                File.AppendAllText(filePath, $"{message}\n");
                Console.WriteLine($"File created successfully. The message was '{message}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implement the logic to log a message to a database.
            Console.WriteLine($"Logging to database. The message was '{message}'");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started.");
            // DO ALL THE WORK!
            _logger.Log("Work done!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger databaseLogger = new DatabaseLogger();
            app = new Application(databaseLogger);
            app.DoWork();

            Console.ReadKey();
        }
    }
}

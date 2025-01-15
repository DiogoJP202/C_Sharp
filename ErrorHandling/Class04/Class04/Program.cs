namespace Class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App running before the try block.");
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }

            Console.WriteLine("App is still running!");
            Console.ReadKey();
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }
    }
}

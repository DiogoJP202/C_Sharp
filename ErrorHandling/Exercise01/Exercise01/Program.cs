namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Trying...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("\nFinally executed.\n");
            }
        }
    }
}

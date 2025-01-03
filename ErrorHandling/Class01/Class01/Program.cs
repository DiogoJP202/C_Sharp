using System.Diagnostics;

namespace Class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Debug.WriteLine("Main method is running."); // This will only appear in debug console.

            try
            {
                Console.WriteLine("Please enter a number");
                // int num1 = int.Parse(Console.ReadLine());
                int num1 = 0;
                int num2 = 2;
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurs: " + ex.Message);
                // This line is only executed during "Debugging".
                Debug.WriteLine(ex.ToString()); // This will only appear in debug console.
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}

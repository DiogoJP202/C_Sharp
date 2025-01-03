using System.Diagnostics;

namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                // int num1 = 0;
                int num2 = 2;
                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divided by zero! - " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a number, not a special character or a letter. - " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number too high. - " + ex.Message);
            }
            catch (Exception ex) // Default Exception
            {
                Console.WriteLine("An error occurs: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This always execute.");
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = "A";
            int number = 4;
            int[] numbers = { 1, 2, 3 };
            try
            {
                int newInt = int.Parse(stringNumber);
                Console.WriteLine(numbers[number]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}

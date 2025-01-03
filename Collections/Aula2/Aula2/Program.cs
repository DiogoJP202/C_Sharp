namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            Console.WriteLine("List of numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            bool hasLargeNumber = numbers.Any(x => x > 20);

            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers in the list.\n");
            } else
            {
                Console.WriteLine("No large numbers in the list.\n");
            }
            
            // Define the predicate to check if a number is greater than 10.

            // It could be using the method instead the Lambda:
            // Predicate<int> isGreaterThanTen = IsGreaterThanTen;

            Predicate<int> isGreaterThanTen = x => x > 10;
            List<int> highTen = numbers.FindAll(isGreaterThanTen);

            Console.WriteLine("\nList of numbers that are 10 and higher:");
            foreach (int number in highTen)
            {
                Console.WriteLine(number);
            }    

            Console.ReadKey();
        }

        // It is like the Lambda expression of: `x => x > 10`.
        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
    }
}

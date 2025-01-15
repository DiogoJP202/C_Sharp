namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The list has been declared for you, use it in your solution.
            List<int> myNumbers = new List<int> { 1, 6, 3 };

            bool isGreaterThanFive = myNumbers.Any(x => x > 5);

            Console.WriteLine(isGreaterThanFive);
            Console.ReadKey();
        }
    }
}

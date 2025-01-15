namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = new List<int> { 1, 2, 3 };

            foreach (int integer in integersList)
            {
                Console.Write($"{integer} ");
            }
        }
    }
}

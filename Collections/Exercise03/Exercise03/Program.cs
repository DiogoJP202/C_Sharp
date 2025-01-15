namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            dictionary.Add("1", new List<int> { 1, 2, 3 });

            foreach (List<int> list in dictionary.Values)
            {
                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }
            }

            Console.ReadKey();
        }
    }
}

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can use de var to create a dictionary.

            var codes = new Dictionary<string, string> {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The state code is {item.Key} and the state name is {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
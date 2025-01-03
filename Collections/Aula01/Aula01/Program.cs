namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a list and initializing it.
            //List<string> colors = new List<string>();

            //colors.Add("Red");
            //colors.Add("Blue");
            //colors.Add("Green");
            //colors.Add("Red");

            List<string> colors = ["Red", "Blue", "Green", "Red"];

            Console.WriteLine("Current colors: ");
            foreach (string color in colors) { Console.WriteLine(color); }

            // This "Remove" method returns TRUE if it found any value to remove and FALSE if it doesn't found any entry.
            colors.Remove("Blue"); // The first entry of "Red" string will be removed. 

            Console.WriteLine("\nCurrent colors: ");
            foreach (string color in colors) { Console.WriteLine(color); }

            // Removes all "Red" entries of colors.
            bool isDeletingSuccessful = colors.Remove("Red");
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("Red");
            }

            Console.WriteLine("\nCurrent colors: ");
            foreach (string color in colors) { Console.WriteLine(color); }

            Console.ReadKey();
        }
    }
}
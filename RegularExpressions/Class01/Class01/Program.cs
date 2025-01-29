using System.Text.RegularExpressions;

namespace Class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string txt = "Hi there, my number is 12314";
            MatchCollection matchCollection = regex.Matches(txt);

            Console.WriteLine($"{matchCollection.Count} hits found:\n{txt}");

            foreach (Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }

            Console.ReadKey();
        }
    }
}

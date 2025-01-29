using System.Text.RegularExpressions;

namespace RegexE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Contact us at support@example.com or sales@example.org.";
            string pattern = @"\w+@\w+\.\w{3}";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine(group[0].Value);
            }

            Console.ReadKey();
        }
    }
}
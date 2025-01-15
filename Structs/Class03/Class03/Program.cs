using Microsoft.VisualBasic;

namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2004, 10, 16);
            Console.WriteLine($"My birthday is {dateTime}");

            // Rertuns today date
            Console.WriteLine(DateTime.Today);

            // Return current time
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be " + tomorrow);

            // Return the day of the week.
            Console.WriteLine("Today is " + DateTime.Today.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(2004));

            int days = DateTime.DaysInMonth(2004, 10);
            Console.WriteLine("Day in Oct 2004: " + days);

            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute: {now.Minute}"); // Returning the current minute.

            Console.WriteLine($"{now.Hour}h:{now.Minute}m:{now.Second}s");

            Console.WriteLine("Write your birthday date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan dayPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {dayPassed.Days} days old.");
            } else
            {
                Console.WriteLine("Wrong input.");
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}

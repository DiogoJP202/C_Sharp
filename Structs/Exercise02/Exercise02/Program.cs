namespace Exercise02
{
    struct Event
    {
        // TODO: Add your code here
        public DateTime StartDate;
        public DateTime EndDate;

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            TimeSpan daysPassed = EndDate.Subtract(StartDate);
            return daysPassed.Days;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            if (EndDate < otherEvent.EndDate)
                return true;
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Event event1 = new Event(DateTime.Parse("2024-07-01"), DateTime.Parse("2024-07-10"));
            Event event2 = new Event(DateTime.Parse("2024-07-05"), DateTime.Parse("2024-07-15"));

            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");
            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");
            Console.ReadKey();
        }
    }
}

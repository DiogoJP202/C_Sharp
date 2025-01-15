namespace Exercise02
{
    public class Person
    {
        public string Name { get; private set; }
        // TODO: Declare a constructor that takes a name and prints a message
        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Person constructor: " + Name);
        }
    }

    public class Employee
        : Person
    {
        public int Id { get; private set; }
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public Employee(string name, int id)
            : base(name)
        {
            Id = id;
            Console.WriteLine($"Employee constructor: {name}, ID: {Id}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John Doe", 123);
        }
    }
}

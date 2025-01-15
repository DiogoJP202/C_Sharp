namespace Class04
{
    public delegate int Comparison<T> (T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparasion)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    // Compare people[i] and people[j] using the provided comparasion delegate.
                    if (comparasion(people[i], people[j]) > 0)
                    {
                        // Swap people[i] wand people[j] if they are in the wrong order.
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
                new Person {Name = "Alice", Age = 30},
                new Person {Name = "Bob", Age = 25},
                new Person {Name = "Charlie", Age = 35},
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            Console.WriteLine("Array sorted by Age:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name} is {person.Age} years old.");
            }

            Console.WriteLine();

            sorter.Sort(people, CompareByName);

            Console.WriteLine("Array sorted by Name:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name} is {person.Age} years old.");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person p1, Person p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }

        static int CompareByName(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }
    }
}

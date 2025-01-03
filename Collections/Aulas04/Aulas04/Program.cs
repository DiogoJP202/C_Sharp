using System.Collections.Generic;

namespace Aulas04
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initalazing a 
            // key - value
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Does", 25, 1250.00));
            employees.Add(2, new Employee("Mariana Goenv", 36, 2000.00));
            employees.Add(3, new Employee("Denis Silva", 22, 3350.00));
            employees.Add(4, new Employee("Rrodigues Martinz", 54, 10000.00));
            employees.Add(5, new Employee("Marcus Smith", 33, 5000.00));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} - {item.Value.Name} earns {item.Value.Salary} and is {item.Value.Age}.");
            }

            Console.ReadKey();
        }
    }
}

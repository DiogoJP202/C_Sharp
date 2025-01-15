namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
        }
    }

    // Base Class (Parent Class or SuperClass): The class whose members are inherited
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // That's a hierarchical inheritance. 
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    .
    class Cat : Animal
    {
        public void Miau()
        {
            Console.WriteLine("Cat is meowing!");
        }
    }
}

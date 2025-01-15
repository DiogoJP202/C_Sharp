namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat();

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat();

            Console.ReadKey();
        }
    }

    // Base Class (Parent Class or SuperClass): The class whose members are inherited
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        // The "virtual" keyword allows to override a method in deriving classes.
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound.");
        }
    }

    // That's a hierarchical inheritance. 
    class Dog : Animal
    {
        // You need to add the "override" keyword to override an virtual method.
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog is barking...");
        }
    }

    class Cat : Animal
    {
        // You need to add the "override" keyword to override an virtual method.
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Cat is meowing!");
        }
    }
}

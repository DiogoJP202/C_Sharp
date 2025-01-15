namespace Class01
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound.");
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                // Part 2 of Polymorphism.
                // We can use the Base class to declare a new objetc of his childs classes.
                Animal myDog = new Dog();
                myDog.MakeSound();

                Console.ReadKey();
            }
        }
    }
}

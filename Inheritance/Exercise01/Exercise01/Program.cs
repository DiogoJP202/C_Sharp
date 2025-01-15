namespace Exercise01
{
    public class Animal
    {
        // TODO: Declare a virtual method MakeSound
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        // TODO: Override the MakeSound method
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
        }
    }
}

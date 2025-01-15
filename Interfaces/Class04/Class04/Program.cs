namespace Class04
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing Wood.");
        }
    }

    public class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;


        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();

            // Injecting dependencies via Setters.
            builder.SetHammer(new Hammer());
            builder.SetSaw(new Saw());  

            builder.BuildHouse();

            Console.ReadKey();
        }
    }
}

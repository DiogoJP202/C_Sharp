namespace Exercise02
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * (_radius * _radius);
        }
    }

    public class Rectangle : IShape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double GetArea()
        {
            return _width * _height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area: {circle.GetArea()}");
            Console.WriteLine($"Area: {rectangle.GetArea()}");
        }
    }
}

namespace Class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            // Rounding up a value.
            Console.WriteLine("Celling: " + Math.Ceiling(15.3));
            // Rounding down a value.
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int num1 = rd.Next(0, 99);
            int num2 = rd.Next(0, 99);
            Console.WriteLine($"Lower of Num1: {num1} and Num2: {num2} is {Math.Min(num1, num2)}.");
            Console.WriteLine($"Higher of Num1: {num1} and Num2: {num2} is {Math.Max(num1, num2)}.");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}");

            Console.WriteLine($"PI is: {Math.PI}");

            Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");

            Console.WriteLine($"Always positive is {Math.Abs(-1*num1)}");

            Console.WriteLine($"Cos of 1 is: {Math.Cos(1)}");

            Console.ReadKey();
        }
    }
}

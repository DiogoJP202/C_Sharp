namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            string[] stringArray = { "One", "Two", "Three", "Four", "Five" };

            PrintArray(intArray);
            PrintArray(stringArray);

            Console.ReadKey();
        }

        // Instead of do that:

        //public static void PrintIntArray(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void PrintStringArray(string[] array)
        //{
        //    foreach (string item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        // We can use Generics:

        // <T> indicates that it's a Generic Method.
        // "T" is just a replacement character for any data type.
        // A Generic method, accepts a generic datatype.
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

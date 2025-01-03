// Arraylist need this libery
using System.Collections;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList1 = new ArrayList();
            // Declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList1.Add(25);
            myArrayList1.Add("Hello");
            myArrayList1.Add(31.13);
            myArrayList1.Add(55);
            myArrayList1.Add(22.5);

            // Delete element with specific value from the arraylist.
            myArrayList1.Remove(55);

            // Delete element at specific position
            myArrayList1.RemoveAt(0);

            Console.WriteLine(myArrayList1.Count);

            double sum = 0;

            foreach(object obj in myArrayList1)
            {
                if(obj is int)
                {
                    sum += (double)obj;
                } else if (obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("The sum result is: " + Math.Round(sum, 2));
            Console.ReadKey();
        }
    }
}

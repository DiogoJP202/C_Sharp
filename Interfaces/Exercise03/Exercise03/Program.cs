namespace Exercise03
{
    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        public void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment creditCard = new CreditCardPayment();
            IPayment payPal = new PayPalPayment();
            creditCard.ProcessPayment();
            payPal.ProcessPayment();
        }
    }
}

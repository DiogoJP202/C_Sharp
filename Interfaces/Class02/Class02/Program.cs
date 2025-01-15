namespace Class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
        }
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor 
        : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            // Implement credit card payment logic.
        }
    }

    public class PaypalProcessor 
        : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal payment of {amount}");
            // Implement Paypal payment logic.
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        // Even if it setted as "IPaymentProcessor" datatype, the fact of it be an Interface allows us to pass any of his implementations (A classe that implements it).
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
}

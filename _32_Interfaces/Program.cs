

namespace _32_Interfaces 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Create instances of different payment processors
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            IPaymentProcessor mockProcessor = new MockPaymentProcessor();

            // Create OrderService instances with different processors
            OrderService realOrderService = new OrderService(creditCardProcessor);
            OrderService testOrderService = new OrderService(mockProcessor);

            // Test with real credit card processor
            Console.WriteLine("Testing with real credit card processor:");
            bool realResult = realOrderService.PlaceOrder(100.50m);
            Console.WriteLine($"Payment processed: {realResult}");

            // Test with mock processor
            Console.WriteLine("\nTesting with mock processor:");
            bool mockResult = testOrderService.PlaceOrder(100.50m);
            Console.WriteLine($"Payment processed: {mockResult}");

            // Demonstrate interface flexibility
            ProcessPaymentWithAnyProcessor(creditCardProcessor, 50.00m);
            ProcessPaymentWithAnyProcessor(mockProcessor, 50.00m);
        }

        // This method shows how interfaces allow for flexibility
        static void ProcessPaymentWithAnyProcessor(IPaymentProcessor processor, decimal amount)
        {
            Console.WriteLine($"\nProcessing payment of ${amount} with {processor.GetType().Name}");
            bool result = processor.ProcessPayment(amount);
            Console.WriteLine($"Payment successful: {result}");
        }
    }
}
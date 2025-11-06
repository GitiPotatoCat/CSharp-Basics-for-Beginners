

namespace _32_Interfaces 
{
    public class MockPaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount) 
        {
            return true;
        }
    }
}
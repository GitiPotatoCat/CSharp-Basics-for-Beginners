

namespace _32_Interfaces 
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount) 
        {
            return amount > 0;
        }
    }
}
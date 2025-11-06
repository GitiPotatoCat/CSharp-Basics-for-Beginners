

namespace _32_Interfaces 
{
    public interface IPaymentProcessor 
    {
        bool ProcessPayment(decimal amount);
    }
}
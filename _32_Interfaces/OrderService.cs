

namespace _32_Interfaces 
{
    public class OrderService 
    {
        private readonly IPaymentProcessor _paymentProcessor;

        
        public OrderService(IPaymentProcessor paymentProcessor) 
        {
            _paymentProcessor = paymentProcessor;
        }


        public bool PlaceOrder(decimal orderAmount) 
        {
            return _paymentProcessor.ProcessPayment(orderAmount);
        }
    }
}

/*
    Loose Coupling:
        In loose coupling, classes depend on abstractions (like interfaces), not concrete implementations. 
        This makes the code more flexible and testable.
    
    Benefits:

    1. You can swap EmailService with another implementation (e.g., SmsService).
    2. Easier to mock IMessageService in unit tests.
    3. Follows Dependency Inversion Principle (D in SOLID).
*/


namespace _25_ClassCoupling 
{
    public class MessageService : IMessageService 
    {
        public void SendMessage(string message) 
        {
            Console.WriteLine("Email sent: " + message);
        }
    }


    public class MessageNotification 
    {
        private IMessageService messageService;

        public MessageNotification(IMessageService service) 
        {
            messageService = service;
        }

        public void NotifyUser() 
        {
            messageService.SendMessage("You have a new notification");
        }
    }
}
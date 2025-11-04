/*
    Tight Coupling:
        
        In tight coupling, one class directly depends on another concrete class.
    This makes the code less flexible and harder to test or change.
            
*/


namespace _25_ClassCoupling 
{
    public class EmailService 
    {
        public void SendEmail(string msg) 
        {
            Console.WriteLine("Email sent: " + msg);
        }
    }


    public class Notification 
    {
        private EmailService emailService = new EmailService();     // tightly coupled

        public void NotifyUser() 
        {
            emailService.SendEmail("You have a new notification.");
        }
    }
}
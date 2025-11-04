
/*
    Class Coupling:
    
    1. Tight Coupling
    2. Loose Coupling
    
*/

namespace _25_ClassCoupling 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Tight Coupling
            var tightCoupling = new EmailService();
            tightCoupling.SendEmail("This is tight coupling");

            var looseCoupling = new MessageService();
            looseCoupling.SendMessage("This is loose coupling");
        }
    }
}
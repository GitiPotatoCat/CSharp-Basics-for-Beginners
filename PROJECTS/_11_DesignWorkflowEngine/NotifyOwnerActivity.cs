

namespace _11_DesignWorkflowEngine 
{
    public class NotifyOwnerActivity : IActivity 
    {
        public void Execute() 
        {
            Console.WriteLine("Sending email to video owner...");
            // Simulate email notification
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Owner notified.");
        }
    }
}
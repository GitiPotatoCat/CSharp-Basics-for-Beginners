

namespace _11_DesignWorkflowEngine 
{
    public class UpdateDatabaseActivity : IActivity 
    {
        public void Execute() 
        {
            Console.WriteLine("Updating video status in the database...");
            // Simulate database update
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Video status updated to 'Processing'.");
        }
    }
}
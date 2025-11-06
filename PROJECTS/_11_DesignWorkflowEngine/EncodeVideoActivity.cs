

namespace _11_DesignWorkflowEngine 
{
    public class EncodeVideoActivity : IActivity 
    {
        public void Execute() 
        {
            Console.WriteLine("Calling third-party video encoding service...");
            // Simulate video encoding
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Video encoding started.");
        }
    }
}
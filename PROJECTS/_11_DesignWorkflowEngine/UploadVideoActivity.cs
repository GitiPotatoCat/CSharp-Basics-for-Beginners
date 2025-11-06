

namespace _11_DesignWorkflowEngine 
{
    public class UploadVideoActivity : IActivity 
    {
        public void Execute() 
        {
            Console.WriteLine("Uploading video to cloud storage...");
            // Simulate video upload
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Video uploaded successfully.");
        }
    }
}
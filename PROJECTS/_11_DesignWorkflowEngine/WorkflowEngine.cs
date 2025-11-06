

namespace _11_DesignWorkflowEngine 
{
    public class WorkflowEngine 
    {
        public void Run(IActivity[] activities) 
        {
            foreach (var activity in activities) 
                activity.Execute();
        }
    }
}
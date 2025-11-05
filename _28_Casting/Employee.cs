

namespace _28_Casting 
{
    public class Employee 
    {
        public string Name { get; set; } = string.Empty;

        public virtual void Work() 
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
}
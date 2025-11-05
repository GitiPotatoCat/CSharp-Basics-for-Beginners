

namespace _28_Casting 
{
    public class Vehicle 
    {
        public string Model { get; set; } = string.Empty;

        public virtual void Start() 
        {
            Console.WriteLine($"{Model} is starting.");
        }
    }
}
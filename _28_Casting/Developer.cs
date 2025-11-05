

namespace _28_Casting 
{
    public class Manager : Employee 
    {
        public override void Work() 
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    public class Developer : Employee 
    {
        public override void Work() 
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }
}
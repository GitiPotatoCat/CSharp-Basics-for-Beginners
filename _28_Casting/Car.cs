

namespace _28_Casting 
{
    public class Car : Vehicle
    {
        public void OpenTrunk() 
        {
            Console.WriteLine($"{Model}'s trunk is open.");
        }

        public override void Start() 
        {
            Console.WriteLine($"{Model} (Car) is starting with keyless ignition.");
        }
    }
}

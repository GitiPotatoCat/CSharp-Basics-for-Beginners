
namespace _27_Composition 
{
    public class Person 
    {
        public string Name { get; set; } = string.Empty;
        public Address HomeAddress { get; set; }   // Composition

        public void DisplayInfo() 
        {
            Console.WriteLine($"{Name} lives at {HomeAddress.Street}, {HomeAddress.City}");
        }
    }
}
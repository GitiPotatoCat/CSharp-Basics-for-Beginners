
namespace _26_Inheritance 
{
    // base class
    public class Animal 
    {
        public string? _animalName { get; set; }

        public void AnimalDetails() 
        {
            Console.WriteLine($"This is {_animalName}");
        }
    }
}
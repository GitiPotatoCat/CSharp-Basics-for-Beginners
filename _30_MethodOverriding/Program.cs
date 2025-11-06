
namespace _30_MethodOverriding 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal theAnimal = new Animal();

            // Call the MakeSound method on each object
            Console.WriteLine("Dog sound:");
            myDog.MakeSound();

            Console.WriteLine("\nCat sound:");
            myCat.MakeSound();

            Console.WriteLine("\nGeneric animal sound:");
            theAnimal.MakeSound();
        }
    }
}

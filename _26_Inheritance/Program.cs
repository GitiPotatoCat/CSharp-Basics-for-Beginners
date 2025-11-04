
namespace _26_Inheritance 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Dog myDog = new Dog();
            myDog._animalName = "Golden Retriever";
            myDog.AnimalDetails();
            myDog.Bark();
        }
    }
}
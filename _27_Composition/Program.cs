/*
    What is Composition?
    
    Composition is a design principle where a class is composed of other 
    classes as part of its internal structure, rather than inheriting from them.
    
    Key Idea:
    
    “Has-a” relationship, not “Is-a”.


    Inheritance: Dog is an Animal
    Composition: Car has an Engine
*/


namespace _27_Composition 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Address address = new Address { Street = "123 Main St", City = "Chennai" };
            Person person = new Person { Name = "Soumyadip", HomeAddress = address };

            person.DisplayInfo();
        }
    }
}
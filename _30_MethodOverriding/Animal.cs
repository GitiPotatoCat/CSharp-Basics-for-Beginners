

namespace _30_MethodOverriding 
{
    // Base class
    public class Animal 
    {
        // Virtual method in base class that can be overridden
        public virtual void MakeSound() 
        {
            Console.WriteLine("Some generic animal sound.");
        }
    }


    // Dervied class
    public class Dog : Animal 
    {
        // Override keyword indicates this method is overrinding
        public override void MakeSound() 
        {
            Console.WriteLine("Woof! Woof!");
        }
    }


    // Another derived class
    public class Cat : Animal 
    {
        // Different implementation for the same method
        public override void MakeSound() 
        {
            Console.WriteLine("Meow!");
        }
    }
}
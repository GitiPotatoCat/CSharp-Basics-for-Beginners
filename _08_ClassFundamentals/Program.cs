using System;
using _08_ClassFundamentals.MyMath;

namespace _08_ClassFundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Person 
            Person person = new Person("Subham", 26, 174.6f, 80);

            // Call the public method Walk
            person.Walk();

            // Call the DoAllActions method to demonstrate protected, private, and internal methods
            person.DoAllActions();

            // Calculator class usage
            int sum = Calculator.Add(10, 5);
            int difference = Calculator.Subtract(10, 5);
            int product = Calculator.Multiply(10, 5);
            double quotient = Calculator.Divide(10, 5);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}
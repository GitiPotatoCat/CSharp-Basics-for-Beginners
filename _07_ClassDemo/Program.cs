using System;

namespace _07_ClassDemo
{
    class Person
    {
        public string? Name;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            // Person class usage
            Person person = new Person();
            person.Name = "Nikhilesh";
            person.Introduce();


            // Calculator class usage
            int number = Calculator.Add(5, 10);

            Console.WriteLine($"The sum is: {number}");
        }
    }
}
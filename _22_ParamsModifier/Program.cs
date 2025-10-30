
namespace _22_ParamsModifier 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Calculator calculator = new Calculator();
            int resultArrayOne = calculator.Add(1, 2, 3);
            int resultArrayTwo = calculator.Add(10, 20, 30, 40);

            Console.WriteLine("Sum of 1, 2, 3: " + resultArrayOne);
            Console.WriteLine("Sum of 10, 20, 30, 40: " + resultArrayTwo);
        }
    }
}
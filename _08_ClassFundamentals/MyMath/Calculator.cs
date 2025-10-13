using static System.Console;

namespace _08_ClassFundamentals.MyMath
{
    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                WriteLine("Error: Division by zero.");
                return double.NaN; // Return Not-a-Number
            }
            return (double)a / b;
        }
    }
}
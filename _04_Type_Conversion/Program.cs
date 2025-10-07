using static System.Console;

namespace _04_Type_Conversion
{
    // Implicit Conversion
    class Money
    {
        public double Amount { get; set; }

        public Money(double amount)
        {
            Amount = amount;
        }

        // Implicit conversion from Money to double
        public static implicit operator double(Money m)
        {
            return m.Amount;
        }
    }

    // Explicit Conversion
    public class INR
    {
        public double Amount { get; set; }

        public INR(double amount)
        {
            Amount = amount;
        }

        // Explicit conversion from double to INR
        public static explicit operator INR(double amount)
        {
            return new INR(amount);
        }
    }


    // main class
    public class Program
    {
        static void Main()
        {
            // Implicit conversion example
            Money money = new Money(27.85);
            double amount1 = money;
            WriteLine(amount1); // Outputs: 27.85

            // Explicit conversion example
            double amount2 = 50.75;
            INR inr = (INR)amount2;  // Explicitly converts double to INR
            WriteLine(inr.Amount);  // Output: 50.75
        }
    }
}
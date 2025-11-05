

namespace _29_Boxing_Unboxing 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*  Boxing Examples */
            int number = 42;        // Value type
            object boxedNumber = number;        // Boxing: int to object
            Console.WriteLine($"Boxed value: {boxedNumber}");

            /*  Unboxing Examples   */
            int unboxedNumber = (int)boxedNumber;       // Unboxing: object back to int
            Console.WriteLine($"Unboxed value: {unboxedNumber}");


            // Boxing and unboxing with other types 
            double pi = 3.14;
            object boxedPi = pi;                    // Boxing
            double unboxedPi = (double)boxedPi;     // Unboxing

            // Example of invalid unboxing (will throw InvalidCastException)
            try {
                int invalidUnbox = (int)boxedPi;    // This will fail
            } catch (InvalidCastException ex) {
                Console.WriteLine("Cannot unbox a double to an int! " + ex.Message.ToString());
            }

            // Performance consideration demonstration
            Console.WriteLine("\nPerformance Example");
            int value = 23;
            for (int i=0; i<3; i++) {
                object boxed = value;   // Boxing occurs
                int unboxed = (int)boxed;   // Unboxing occurs
                Console.WriteLine($"Iteration {i}: {unboxed}");
            }
        }
    }
}

using static System.Console;

namespace _05_TypeConversion_ExceptionHandling
{
    class Program
    {
        // Example 1: Numeric conversions with overflow
        protected static void Example1()
        {
            try
            {
                int i = 300;
                byte b = Convert.ToByte(i); // Overflow
                WriteLine($"Converted byte: {b}");
            }
            catch (OverflowException ex)
            {
                WriteLine($"[Example1] Overflow Exception: {ex.Message}");
            }

            try
            {
                int i = 123;
                byte b = Convert.ToByte(i); // OK
                WriteLine($"[Example1] Successfully converted byte: {b}");
            }
            catch (OverflowException ex)
            {
                WriteLine($"[Example1] Overflow Exception: {ex.Message}");
            }
        }

        // Example 2: String to numeric conversions
        protected static void Example2()
        {
            try
            {
                string str = "123abc";
                int num = Convert.ToInt32(str); // FormatException
                WriteLine($"[Example2] Converted number: {num}");
            }
            catch (FormatException ex)
            {
                WriteLine($"[Example2] Format Exception: {ex.Message}");
            }

            try
            {
                string str = "456";
                int num = Convert.ToInt32(str); // OK
                WriteLine($"[Example2] Successfully converted number: {num}");
            }
            catch (FormatException ex)
            {
                WriteLine($"[Example2] Format Exception: {ex.Message}");
            }

            try
            {
                string? str = null;
                int num = Convert.ToInt32(str); // ArgumentNullException
                WriteLine($"[Example2] Converted number: {num}");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"[Example2] Null Exception: {ex.Message}");
            }
        }

        // Example 3: Custom object to string and back
        protected static void Example3()
        {
            try
            {
                object obj = "789";
                int num = Convert.ToInt32(obj); // OK
                WriteLine($"[Example3] Converted from object: {num}");
            }
            catch (Exception ex)
            {
                WriteLine($"[Example3] Exception: {ex.Message}");
            }

            try
            {
                object obj = new object();
                int num = Convert.ToInt32(obj); // InvalidCastException
                WriteLine($"[Example3] Converted from object: {num}");
            }
            catch (InvalidCastException ex)
            {
                WriteLine($"[Example3] Invalid Cast: {ex.Message}");
            }
        }

        // Example 4: Safe conversion using TryParse
        protected static void Example4()
        {
            string input1 = "123";
            string input2 = "abc";
            string? input3 = null;

            // Case 1: Valid integer string
            if (int.TryParse(input1, out int result1))
            {
                WriteLine($"[Example4] Successfully parsed: {result1}");
            }
            else
            {
                WriteLine("[Example4] Failed to parse input1");
            }

            // Case 2: Invalid integer string
            if (int.TryParse(input2, out int result2))
            {
                WriteLine($"[Example4] Successfully parsed: {result2}");
            }
            else
            {
                WriteLine("[Example4] Failed to parse input2");
            }

            // Case 3: Null string
            if (int.TryParse(input3, out int result3))
            {
                WriteLine($"[Example4] Successfully parsed: {result3}");
            }
            else
            {
                WriteLine("[Example4] Failed to parse input3 (null)");
            }
        }


        static void Main()
        {
            Example1();
            WriteLine(new string('-', 40));
            Example2();
            WriteLine(new string('-', 40));
            Example3();
            WriteLine(new string('-', 40));
            Example4();
        }
    }
}
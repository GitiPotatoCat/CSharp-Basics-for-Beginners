using static System.Console;

namespace _02_Variables_and_Constraints
{
    class Program
    {
        protected static void Example_Sbyte()
        {
            // sbyte: -128 to 127
            sbyte a = 100;
            sbyte b = 0;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            sbyte x = -128;
            sbyte y = -5;
            sbyte z = (sbyte)(x + y);
            WriteLine($"z = {z}");   // z = 123
        }

        protected static void Example_byte()
        {
            // byte: 0 to 255
            byte a = 100;
            byte b = 200;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            byte x = 250;
            byte y = 10;
            byte z = (byte)(x + y);
            WriteLine($"z = {z}");   // z = 4
        }

        protected static void Example_short()
        {
            // short: -32,768 to 32,767
            short a = 10000;
            short b = 20000;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            short x = 20000;
            short y = 20000;
            short z = (short)(x + y);
            WriteLine($"z = {z}");   // z = -25536
        }




        // driver method
        static void Main()
        {
            Example_Sbyte();
            WriteLine();
            Example_byte();
            WriteLine();
            Example_short();
            WriteLine();
        }
    }
}
using static System.Console;

namespace Program
{
    class _02_Variables_and_Constraints
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

        protected static void Example_ushort()
        {
            // ushort: 0 to 65,535
            ushort a = 10000;
            ushort b = 50000;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            ushort x = 40000;
            ushort y = 40000;
            ushort z = (ushort)(x + y);
            WriteLine($"z = {z}");   // z = 14464
        }

        protected static void Example_int()
        {
            // int: -2,147,483,648 to 2,147,483,647
            int a = 1_000_000_000;
            int b = 2_000_000_000;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            int x = 2_000_000_000;
            int y = 2_000_000_000;
            int z = x + y;
            WriteLine($"z = {z}");   // z = -294967296
        }

        protected static void Example_uint()
        {
            // uint: 0 to 4,294,967,295
            uint a = 1_000_000_000;
            uint b = 3_000_000_000;
            WriteLine($"a = {a}, b = {b}");

            // OverflowException
            uint x = 3_000_000_000;
            uint y = 3_000_000_000;
            uint z = x + y;
            WriteLine($"z = {z}");   // z = 1610612736
        }

        protected static void Example_long()
        {
            // long: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long a = 5_000_000_000;
            long b = 6_000_000_000;
            WriteLine($"a = {a}, b = {b}");

            // No OverflowException
            long x = 9_000_000_000;
            long y = 8_000_000_000;
            long z = x + y;
            WriteLine($"z = {z}");   // z = 17000000000
        }

        protected static void Example_ulong()
        {
            // ulong: 0 to 18,446,744,073,709,551,615
            ulong a = 5_000_000_000;
            ulong b = 15_000_000_000;
            WriteLine($"a = {a}, b = {b}");

            // No OverflowException
            ulong x = 18_000_000_000;
            ulong y = 10_000_000_000;
            ulong z = x + y;
            WriteLine($"z = {z}");   // z = 28000000000
        }



        protected static void Example_RealNumbers()
        {
            // float: ±1.5 x 10^−45 to ±3.4 x 10^38, 7 digits precision
            float f1 = 1.234567f;
            float f2 = 1.2345678f;
            WriteLine($"f1 = {f1}, f2 = {f2}");   // f1 = 1.234567, f2 = 1.2345678

            // double: ±5.0 × 10^−324 to ±1.7 × 10^308, 15-16 digits precision
            double d1 = 1.234567890123456;
            double d2 = 1.2345678901234567;
            WriteLine($"d1 = {d1}, d2 = {d2}");   // d1 = 1.23456789012346, d2 = 1.23456789012346

            // decimal: ±1.0 x 10^-28 to ±7.9 x 10^28, 28-29 digits precision
            decimal m1 = 1.2345678901234567890123456789M;
            decimal m2 = 1.23456789012345678901234567891M;
            WriteLine($"m1 = {m1}, m2 = {m2}");   // m1 = 1.2345678901234567890123456789, m2 = 1.2345678901234567890123456789
        }



        protected static void Example_char()
        {
            // char: A single 16-bit Unicode character
            char ch1 = 'A';
            char ch2 = '\u0041'; // Unicode representation of 'A'
            WriteLine($"ch1 = {ch1}, ch2 = {ch2}");   // ch1 = A, ch2 = A

            char ch3 = 'あ'; // Japanese character
            char ch4 = '\u3042'; // Unicode representation of 'あ'
            WriteLine($"ch3 = {ch3}, ch4 = {ch4}");   // ch3 = あ, ch4 = あ

            char ch5 = 'è';  // Italian character
            char ch6 = '\u00E8'; // Unicode representation of 'è'
            WriteLine($"ch5 = {ch5}, ch6 = {ch6}");   // ch5 = è, ch6 = è
        }


        protected static void Example_bool()
        {
            // bool: true or false
            bool flag1 = true;
            bool flag2 = false;
            WriteLine($"flag1 = {flag1}, flag2 = {flag2}");   // flag1 = True, flag2 = False
        }



        // driver method
        static void Main()
        {
            WriteLine("Demonstrating various integral numbers");
            WriteLine("======================================");
            WriteLine("sbyte:");
            Example_Sbyte();
            WriteLine("byte:");
            Example_byte();
            WriteLine("short:");
            Example_short();
            WriteLine("ushort:");
            Example_ushort();
            WriteLine("int:");
            Example_int();
            WriteLine("uint:");
            Example_uint();
            WriteLine("long:");
            Example_long();
            WriteLine("ulong:");
            Example_ulong();
            WriteLine("End of demonstration of various integral numbers\n======================================");


            WriteLine("Demonstrating various real numbers");
            WriteLine("======================================");
            Example_RealNumbers();
            WriteLine("End of demonstration of various real numbers\n======================================");


            WriteLine("Demonstrating char");
            WriteLine("======================================");
            Example_char();
            WriteLine("End of demonstration of char\n======================================");


            WriteLine("Demonstrating bool");
            WriteLine("======================================");
            Example_bool();
            WriteLine("End of demonstration of bool\n======================================");
        }
    }
}
using static System.Console;

namespace _06_Operators
{
    class Program
    {
        protected static void ArithmeticOperators()
        {
            int a = 18;
            int b = 6;

            WriteLine("Addition of {0} + {1} = {2}", a, b, a + b);
            WriteLine("Subtraction of {0} - {1} = {2}", a, b, a - b);
            WriteLine("Multiplication of {0} * {1} = {2}", a, b, a * b);
            WriteLine("Division of {0} / {1} = {2}", a, b, a / b);
            WriteLine("Remainder of {0} % {1} = {2}", a, b, a % b);

            // Increment and Decrement Operators
            WriteLine("Pre Incrementing {0} = {1}", a, ++a);
            WriteLine("Post Incrementing {0} = {1}", a, a++);
            WriteLine("After Post Incrementing {0}", a);

            WriteLine("Pre Decrementing {0} = {1}", a, --a);
            WriteLine("Post Decrementing {0} = {1}", a, a--);
            WriteLine("After Post Decrementing {0}", a);

            WriteLine("Incrementing {0} by 5 = {1}", a, a += 5);
            WriteLine("Decrementing {0} by 5 = {1}", a, a -= 5);
        }

        protected static void ComparisonOperators()
        {
            int a = 5;
            int b = 10;

            WriteLine("{0} == {1} : {2}", a, b, a == b);
            WriteLine("{0} != {1} : {2}", a, b, a != b);
            WriteLine("{0} > {1} : {2}", a, b, a > b);
            WriteLine("{0} < {1} : {2}", a, b, a < b);
            WriteLine("{0} >= {1} : {2}", a, b, a >= b);
            WriteLine("{0} <= {1} : {2}", a, b, a <= b);
        }

        protected static void AssignmentOperators()
        {
            int a = 12;
            int b = 3;

            WriteLine("a = {0}", a);
            WriteLine("b = {0}", b);

            WriteLine("a += b : {0}", a += b);
            WriteLine("a -= b : {0}", a -= b);
            WriteLine("a *= b : {0}", a *= b);
            WriteLine("a /= b : {0}", a /= b);
        }

        protected static void LogicalOperators()
        {
            bool a = true;
            bool b = false;

            WriteLine("{0} && {1} : {2}", a, b, a && b);
            WriteLine("{0} || {1} : {2}", a, b, a || b);
            WriteLine("!{0} : {1}", b, !b);
        }

        protected static void BitwiseOperators()
        {
            int a = 5;      // 0101 in binary
            int b = 3;      // 0011 in binary

            WriteLine("{0} & {1} : {2}", a, b, a & b);   // AND
            WriteLine("{0} | {1} : {2}", a, b, a | b);   // OR
            WriteLine("{0} ^ {1} : {2}", a, b, a ^ b);   // XOR
            WriteLine("~{0} : {1}", a, ~a);               // NOT
            WriteLine("{0} << 1 : {1}", a, a << 1);       // Left Shift
            WriteLine("{0} >> 1 : {1}", a, a >> 1);       // Right Shift
        }


        static void Main()
        {
            WriteLine("Arithmetic Operators");
            ArithmeticOperators();

            WriteLine("\nComparison Operators");
            ComparisonOperators();

            WriteLine("\nAssignment Operators");
            AssignmentOperators();

            WriteLine("\nLogical Operators");
            LogicalOperators();

            WriteLine("\nBitwise Operators");
            BitwiseOperators();
        }
    }
}
using static System.Console;

namespace _03_Variables
{
    class Program
    {
        protected static void VarKeyword()
        {
            var number = 5; // int
            var count = 12; // int
            var totalPrice = 21.89f; // float
            var character = 'B'; // char
            var processorBrand = "Ryzen"; // string
            var isWorking = true; // bool

            WriteLine(number);
            WriteLine(count);
            WriteLine(totalPrice);
            WriteLine(character);
            WriteLine(processorBrand);
            WriteLine(isWorking);
        }


        protected static void ConstantsExample()
        {
            const double Pi = 3.14;
            const int MonthsInYear = 12;
            const int HoursInDay = 24;

            // Pi = 3.145; // Error: The left-hand side of an assignment must be a variable, property or indexer
            WriteLine(Pi);
            WriteLine(MonthsInYear);
            WriteLine(HoursInDay);
        }


        static void Main()
        {
            byte number = 2; // 1 byte
            int count = 10; // 4 bytes
            float totalPrice = 20.95f; // 4 bytes
            char character = 'A'; // 2 bytes
            string laptopBrand = "Lenovo"; // 2 bytes per character
            bool isWorking = true; // 1 byte

            WriteLine(number);
            WriteLine(count);
            WriteLine(totalPrice);
            WriteLine(character);
            WriteLine(laptopBrand);
            WriteLine(isWorking);


            WriteLine("\n--- Using var keyword ---");
            VarKeyword();


            // Example
            WriteLine("\n--- Example ---");
            WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            WriteLine("\n--- Using constants ---");
            ConstantsExample();
        }
    }
}
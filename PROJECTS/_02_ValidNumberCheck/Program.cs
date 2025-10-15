/*
    1- Write a program and ask the user to enter a number. 
       The number should be between 1 to 10. If the user enters a valid number, 
       display "Valid" on the console. Otherwise, display "Invalid". 
       (This logic is used a lot in applications where values entered into input boxes need to be validated.)
*/

using static System.Console;

namespace _02_ValidNumberCheck 
{
    public class Program 
    {
        private static int inputNumber = 0;
        private static bool IsValidInput = false;

        protected static bool CheckValidNum(int num) 
        {
            return num >= 1 && num <= 10;
        }

        protected static void UserInput() 
        {
            WriteLine("Choice a number between 1 to 10");
            
            while (!IsValidInput) {
                Write("Enter an integer number: ");
                string? userInput = ReadLine();

                // Exception handling Parsing
                if (int.TryParse(userInput, out inputNumber)) {
                    if (CheckValidNum(inputNumber)) {
                        WriteLine("Valid");
                        IsValidInput = true;
                    } else {
                        WriteLine("Invalid");
                    }
                } else {
                    WriteLine("Invalid input, try to input a numeric value");
                }
            }
        }

        // driver code
        static void Main(string[] args) 
        {
            UserInput();
        }
    }
}
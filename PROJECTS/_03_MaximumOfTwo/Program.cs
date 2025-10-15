/*
    2- Write a program which takes two numbers from the 
       console and displays the maximum of the two. 
*/

using static System.Console;

namespace _03_MaximumOfTwo 
{
    public class Program 
    {
        private static int InputFirstNum = 0, InputSecondNum = 0;
        private static bool IsValidInput = false;

        protected static int FindMaximumBetweenTwo(int x, int y) 
        {
            return x > y ? x : y;
        }

        // driver code
        static void Main() 
        {
            WriteLine("Find maximum between two numbers");
            
            while (!IsValidInput) {
                Write("Enter first integer: ");
                string? firstNum = ReadLine();
                Write("Enter second integer: ");
                string? secondNum = ReadLine();

                // Exception handling using Parsing
                if (int.TryParse(firstNum, out InputFirstNum) && int.TryParse(secondNum, out InputSecondNum)) {
                    int result = FindMaximumBetweenTwo(InputFirstNum, InputSecondNum);
                    WriteLine("Maximum: {0}", result);
                    IsValidInput = true;
                } else {
                    WriteLine("Invalid input. Make sure both input numbers are integer");
                }
            }
        }
    }
}
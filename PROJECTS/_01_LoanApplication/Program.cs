using static System.Console;

namespace _01_LoanApplication
{
    public class Program
    {
        private static int ageInput = 0;
        private static int yearsStayedInput = 0;
        private static string userName = string.Empty;

        private readonly bool isOver18 = ageInput >= 18;
        private readonly char isCitizen = yearsStayedInput >= 5 ? 'Y' : 'N';


        private bool IsEligible => isOver18 && (isCitizen == 'Y');


        protected static void InputDetails()
        {
            // Input for age and stayed years in the country with proper exception handling 
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Write("Enter your age: ");
                    string? ageStr = ReadLine();
                    ageInput = ageStr != null ? int.Parse(ageStr.Trim()) : 0;

                    Write("Enter number of years you have stayed in the country: ");
                    string? yearsStayedStr = ReadLine();
                    yearsStayedInput = yearsStayedStr != null ? int.Parse(yearsStayedStr.Trim()) : 0;

                    if (ageInput < 0 || yearsStayedInput < 0)
                    {
                        WriteLine("Please enter non-negative values for age and years stayed.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Invalid input. Please enter numeric values for age and years stayed.");
                }
                catch (OverflowException)
                {
                    WriteLine("The number entered is too large. Please enter a reasonable value.");
                }
                catch (Exception ex)
                {
                    WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }


        // driver code
        static void Main(string[] args)
        {
            WriteLine("Loan Application Verification");
            WriteLine("-----------------------------\n");
            
            Write("Enter your name: ");
            string? nameInput = ReadLine();
            userName = nameInput != null ? nameInput.Trim() : string.Empty;


            // Input details method call
            InputDetails();


            Program program = new Program();

            if (program.IsEligible)
                WriteLine($"{userName}, you are eligible to apply for a loan!");
            else
            {
                WriteLine($"{userName}, you are not eligible to apply for a loan.");
                if (!program.isOver18)
                    WriteLine("Reason: You must be at least 18 years old.");
                if (program.isCitizen == 'N')
                    WriteLine("Reason: You must have stayed in the country for at least 5 years.");
            }
        }
    }
}
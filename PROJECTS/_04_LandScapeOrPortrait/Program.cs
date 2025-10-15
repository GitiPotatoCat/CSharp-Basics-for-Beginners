/*
    3- Write a program and ask the user to enter the width and height of an image. 
       Then tell if the image is landscape or portrait.
*/

using static System.Console;


namespace _04_LandScapeOrPortrait 
{
    class Program 
    {
        private static int InputWidth = 0, InputHeight = 0;
        private static bool IsValidInput = false;

        protected static string CheckIfPortrait(int w, int h) 
        {
            return w > h ? "portrait" : "landscape";
        }

        // driver code
        static void Main() 
        {
            WriteLine("Check the picture portrait or landscape");

            while (!IsValidInput) {
                Write("Enter width (cm.): ");
                string? width = ReadLine();
                Write("Enter height (cm.): ");
                string? height = ReadLine();

                // Exception handling Parsing
                if (int.TryParse(width, out InputWidth) && int.TryParse(height, out InputHeight)) {
                    if (InputWidth == InputHeight)
                        WriteLine("It is Square Painting.");

                    string res = CheckIfPortrait(InputWidth, InputHeight);
                    WriteLine("Picture type: {0}", res);
                    IsValidInput = true;
                } else {
                    WriteLine("Try to input an integer value");
                }
            }
        }
    }
}
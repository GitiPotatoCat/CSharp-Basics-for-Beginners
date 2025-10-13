using System;

namespace _11_String 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var firstName = "Soumyadip";
            var lastName = "Majumder";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Hritish", "Saras", "Kartikeya" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);


            var text = "Folder1\\Folder2\\nc:\\path";
            Console.WriteLine(text);


            // Verbatim string literal
            var verbatim = @"Folder1\Folder2\nc:\path";
            Console.WriteLine(verbatim);
        }
    }
}
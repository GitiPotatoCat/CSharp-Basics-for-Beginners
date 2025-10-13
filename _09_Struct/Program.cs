using System;

namespace _09_Struct 
{
    public struct Book 
    {
        public string Title;
        public string Author;
        public int YearPublished;

        public Book(string Title, string Author, int Year) {
            this.Title = Title;
            this.Author = Author;
            YearPublished = Year;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}");
        }
    }


    class Program {
        static void Main() {
            // Example of a Bengali book
            Book book1 = new Book("Pather Panchali", "Bibhutibhushan Bandyopadhyay", 1929);
            Console.WriteLine("Book 1 Info:");
            book1.DisplayInfo();


            // Value type behavior : assigning one struct to another copies the value
            Book book2 = book1; // Copying the value
            Console.WriteLine("\nBook 2 Info (after copying from Book 1):");
            book2.DisplayInfo();
            book2.Title = "Aparajito"; // Modifying book2 does not affect book1
            book2.Author = "Satyajit Ray";
            book2.YearPublished = 1956;
            Console.WriteLine("\nBook 2 Info (after modification):");
            book2.DisplayInfo();
            Console.WriteLine("\nBook 1 Info (remains unchanged):");
            book1.DisplayInfo(); // book1 remains unchanged
        }
    }
}
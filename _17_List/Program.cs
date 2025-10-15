using System;
using System.Collections.Generic;
using System.Linq;


namespace _17_List 
{
    class Program 
    {
        static void Main() 
        {
            // Create and initialize a List
            List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

            Console.WriteLine("Initial List: " + string.Join(", ", numbers));

            // Properties
            Console.WriteLine($"Count: {numbers.Count}");
            Console.WriteLine($"Capacity: {numbers.Capacity}");

            // Add elements
            numbers.Add(10);
            numbers.AddRange(new int[] { 20, 30 });
            Console.WriteLine("After Add & AddRange: " + string.Join(", ", numbers));

            // Insert element
            numbers.Insert(2, 15);
            Console.WriteLine("After Insert at index 2: " + string.Join(", ", numbers));

            // Remove elements
            numbers.Remove(20); // removes first occurrence
            numbers.RemoveAt(0); // removes by index
            Console.WriteLine("After Remove & RemoveAt: " + string.Join(", ", numbers));

            // Check if element exists
            Console.WriteLine($"Contains 10? {numbers.Contains(10)}");

            // Find index
            Console.WriteLine($"Index of 10: {numbers.IndexOf(10)}");

            // Sort and Reverse
            numbers.Sort();
            Console.WriteLine("Sorted List: " + string.Join(", ", numbers));

            numbers.Reverse();
            Console.WriteLine("Reversed List: " + string.Join(", ", numbers));

            // Convert to array
            int[] array = numbers.ToArray();
            Console.WriteLine("Converted to Array: " + string.Join(", ", array));

            // Clear list
            // numbers.Clear();
            // Console.WriteLine("After Clear: " + string.Join(", ", numbers));

            // LINQ operations
            List<int> sample = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = sample.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            var sum = sample.Sum();
            var max = sample.Max();
            var min = sample.Min();
            var avg = sample.Average();

            Console.WriteLine($"Sum: {sum}, Max: {max}, Min: {min}, Avg: {avg}");

            var sortedDesc = sample.OrderByDescending(n => n).ToList();
            Console.WriteLine("Sorted Descending: " + string.Join(", ", sortedDesc));

            var firstThree = sample.Take(3).ToList();
            Console.WriteLine("First 3 elements: " + string.Join(", ", firstThree));

            var skipFive = sample.Skip(5).ToList();
            Console.WriteLine("Skip first 5 elements: " + string.Join(", ", skipFive));
        }
    }
}
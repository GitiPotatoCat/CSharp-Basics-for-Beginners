using System;
using System.Linq;

namespace _16_Array {
    class Program {
        static void Main() {
            // Declaration and Initialization
            int[] arr = new int[3]; // size = 3
            int[] arr2 = { 1, 2, 3, 4 };

            // Multi-dimensional array
            int[,] matrix = new int[2, 3]; // 2 rows, 3 columns

            // Jagged array
            int[][] jagged = new int[2][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5 };

            // Access elements
            Console.WriteLine($"First element: {arr2[0]}");
            Console.WriteLine($"Last element: {arr2[arr2.Length - 1]}");

            // Built-in properties
            Console.WriteLine($"Length of arr2: {arr2.Length}");
            Console.WriteLine($"Rank of matrix: {matrix.Rank}");

            // Built-in methods
            Array.Sort(arr2);
            Console.WriteLine("Sorted arr2: " + string.Join(", ", arr2));

            Array.Reverse(arr2);
            Console.WriteLine("Reversed arr2: " + string.Join(", ", arr2));

            int index = Array.IndexOf(arr2, 3);
            Console.WriteLine($"Index of 3: {index}");

            Array.Clear(arr2, 0, arr2.Length);
            Console.WriteLine("Cleared arr2: " + string.Join(", ", arr2));

            int[] copyArr = new int[arr2.Length];
            Array.Copy(arr2, copyArr, arr2.Length);
            Console.WriteLine("Copied arr2: " + string.Join(", ", copyArr));

            Array.Resize(ref arr2, 6);
            Console.WriteLine("Resized arr2: " + string.Join(", ", arr2));

            // LINQ methods for arrays
            int[] arr3 = { 1, 2, 3, 4, 5 };
            var evenNumbers = arr3.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            var sum = arr3.Sum();
            var max = arr3.Max();
            var min = arr3.Min();
            var avg = arr3.Average();

            Console.WriteLine($"Sum: {sum}, Max: {max}, Min: {min}, Avg: {avg}");
        }
    }
}
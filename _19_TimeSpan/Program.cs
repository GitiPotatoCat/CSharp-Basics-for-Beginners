using System;

namespace _19_TimeSpan 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine(timeSpan1);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: {0}", duration);

            // Properties
            Console.WriteLine("Minutes: {0}", timeSpan.Minutes);
            Console.WriteLine("Total Minutes: {0}", timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            // ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
using System;

namespace _15_Random 
{
    class Program 
    {
        protected static void Example() 
        {
            var random = new Random();

            var buffer = new char[10];

            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }


        static void Main() 
        {
            // Random instance
            var random = new Random();

            // Generate random byte (0–255)
            byte byte_random = (byte)random.Next(0, 256);
            Console.WriteLine(byte_random);

            // Generate random integers (1–10)
            for (int i = 0; i < 5; i++)
                Console.Write(random.Next(1, 10) + ", ");

            Console.WriteLine();

            for (var i = 0; i < 10; i++)
                Console.Write((char)random.Next(97, 122) + " ");

            Console.WriteLine();

            // Example method
            Example();
        }
    }
}
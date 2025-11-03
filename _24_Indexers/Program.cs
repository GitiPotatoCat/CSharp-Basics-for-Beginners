using static System.Console;

namespace _24_Indexers 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // If command line arguments are provided, handle them directly
            if (args.Length > 0)
            {
                HandleCommandLineArgs(args);
                return;
            }

            // Interactive mode
            while (true)
            {
                DisplayMenu();
                string? choice = ReadLine()?.Trim().ToLower();
                
                switch (choice)
                {
                    case "1":
                        RunDataSamplesDemo();
                        break;
                    case "2":
                        RunArgsProcessorDemo();
                        break;
                    case "exit":
                    case "q":
                        return;
                    default:
                        WriteLine("Invalid choice! Please try again or type 'exit' to quit.");
                        break;
                }
                
                WriteLine("\nPress any key to continue...");
                ReadKey();
                Clear();
            }
        }

        static void DisplayMenu()
        {
            Clear();
            WriteLine("=== Indexers Demonstration ===");
            WriteLine("1. DataSamples Demo");
            WriteLine("2. ArgsProcessor Demo");
            WriteLine("Type 'exit' or 'q' to quit");
            Write("\nEnter your choice: ");
        }

        static void HandleCommandLineArgs(string[] args)
        {
            if (args[0] == "--demo" && args.Length > 1)
            {
                switch (args[1].ToLower())
                {
                    case "1":
                        RunDataSamplesDemo();
                        break;
                    case "2":
                        RunArgsProcessorDemo(args.Skip(2).ToArray());
                        break;
                    default:
                        ShowUsage();
                        break;
                }
            }
            else
            {
                // Assume direct ArgsProcessor commands
                RunArgsProcessorDemo(args);
            }
        }

        static void ShowUsage()
        {
            WriteLine("Usage:");
            WriteLine("  Interactive mode:");
            WriteLine("    dotnet run");
            WriteLine("\n  Direct demo selection:");
            WriteLine("    dotnet run -- --demo 1           # Run DataSamples demo");
            WriteLine("    dotnet run -- --demo 2 [options] # Run ArgsProcessor demo");
            WriteLine("\n  Direct ArgsProcessor commands:");
            WriteLine("    dotnet run -- -help              # Show ArgsProcessor help");
            WriteLine("    dotnet run -- -version           # Show version");
            WriteLine("    dotnet run -- -info              # Show system info");
            WriteLine("    dotnet run -- -test              # Run test measurement");
        }

        static void RunDataSamplesDemo()
        {
            WriteLine("\n=== DataSamples Demonstration ===");
            var weatherData = new DataSamples(10000);

            // Reading data demonstration
            WriteLine("\nReading measurements from different pages:");
            WriteLine($"Measurement at index 500:  {weatherData[500]}");
            WriteLine($"Measurement at index 1500: {weatherData[1500]}");
            WriteLine($"Measurement at index 2500: {weatherData[2500]}");

            // Modifying data demonstration
            WriteLine("\nModifying and reading back data:");
            var newMeasurement = new Measurements(75.5, 45.2, 29.92);
            weatherData[1000] = newMeasurement;
            WriteLine($"New measurement at index 1000: {weatherData[1000]}");

            // Error handling demonstration
            WriteLine("\nTesting bounds checking:");
            try
            {
                _ = weatherData[-1];
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine($"Expected error: {ex.Message}");
            }

            try
            {
                _ = weatherData[10000];
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine($"Expected error: {ex.Message}");
            }

            // Page caching demonstration
            WriteLine("\nPage Caching (accessing multiple indices):");
            for (int i = 0; i < 6000; i += 1000)
            {
                WriteLine($"Access index {i}: {weatherData[i]}");
            }
        }

        static void RunArgsProcessorDemo(string[]? args = null)
        {
            args ??= Array.Empty<string>();
            WriteLine("\n=== ArgsProcessor Demonstration ===");
            
            var actions = new ArgsActions();
            
            // Configure available actions
            actions.SetOption("-help", () => {
                WriteLine("Available commands:");
                WriteLine("  -help    : Show this help message");
                WriteLine("  -version : Show program version");
                WriteLine("  -info    : Show system information");
                WriteLine("  -test    : Run a test measurement");
            });

            actions.SetOption("-version", () => {
                WriteLine("Program Version: 1.0.0");
            });

            actions.SetOption("-info", () => {
                WriteLine($"Current Time: {DateTime.Now}");
                WriteLine($"OS Version: {Environment.OSVersion}");
            });

            actions.SetOption("-test", () => {
                var weatherData = new DataSamples(100);
                WriteLine("Test Measurement:");
                WriteLine($"Sample at index 0:  {weatherData[0]}");
                WriteLine($"Sample at index 50: {weatherData[50]}");
            });

            var processor = new ArgsProcessor(actions);

            if (args.Length == 0)
            {
                WriteLine("No arguments provided. Available commands:");
                actions["-help"]?.Invoke();
                return;
            }

            processor.Process(args);
        }
    }
}
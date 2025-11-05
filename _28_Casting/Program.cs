
namespace _28_Casting 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*  Upcasting   */

            // Create derived class objects
            Manager manager = new Manager { Name = "Priya" };
            Developer developer = new Developer { Name = "Dona" };

            // Upcasting: treating derived objects as base class
            List<Employee> employees = new List<Employee>();
            employees.Add(manager);     // Upcast to Employee
            employees.Add(developer);   // Upcast to Employee

            // Polymorphic behavior
            foreach (Employee emp in employees)
                emp.Work();     // Calls the overriden method based on actual type



            /* Downcasting */

            // First have to do Upcasting: Car object stored as Vehicle
            Vehicle vehicle = new Car { Model = "Honda City" };
            vehicle.Start();    // Polymorphic call

            // Downcasting: back to Car to access Car-specific method
            if (vehicle is Car car)
                car.OpenTrunk();    // Safe downcast
            else
                Console.WriteLine("Downcastin failed.");
        }
    }
}
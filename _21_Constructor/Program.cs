
namespace _21_Constructor 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


            var customerOne = new Customer(1, "Shyam");
            Console.WriteLine("Customer One Id: " + customerOne.Id);
            Console.WriteLine("Customer One Name: " + customerOne.Name);


            var order = new Order();
            customer.Orders?.Add(order);
        }
    }
}
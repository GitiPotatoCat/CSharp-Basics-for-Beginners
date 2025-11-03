using static System.Console;

namespace _23_Fields 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var customer = new Customer(1);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            WriteLine("Numbers of orders: " + customer.Orders.Count);
            customer.Promote();
            WriteLine("Updated number of orders: " + customer.Orders.Count);


            var customer1 = new Customer(2);

            customer1.DemoOrd.Add(new Order());
            customer1.DemoOrd.Add(new Order());
            WriteLine("Number of demos: " + customer1.DemoOrd.Count);
            customer1.Promote();
            WriteLine("Updated number of demos: " + customer1.DemoOrd.Count);

        }
    }
}
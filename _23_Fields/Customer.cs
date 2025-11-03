using System.Collections.Generic;

namespace _23_Fields 
{
    internal class Customer 
    {
        public int Id;
        public string Name = string.Empty;
        public List<Order> DemoOrd = new List<Order>();
        public readonly List<Order> Orders = new List<Order>();


        
        public Customer(int Id) {
            this.Id = Id;
        }

        public Customer(int Id, string Name) 
            : this(Id) 
        {
            this.Name = Name;
        }

        public void Promote() {
            DemoOrd = new List<Order>();
            //...
        }
    }
}
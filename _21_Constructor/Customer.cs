
namespace _21_Constructor 
{
    public class Customer {
        public int? Id;
        public string? Name;
        public List<Order>? Orders;



        // default constructor
        public Customer() {
            Orders = [];
        }

        public Customer(int Id)
            : this() 
        {
            this.Id = Id;
        }

        public Customer(int id, string name)
            : this(id) 
        {
            Name = name;
        }
    }
}
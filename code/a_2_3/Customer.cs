using System.Collections.Generic;

namespace Week20.A.Two.Three
{
    class Customer
    {
        public string Name;
        public string Email;
        public string Address;
        public readonly List<Order> CompletedOrders = new List<Order>();
        public Order OpenOrder;

        public Customer(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
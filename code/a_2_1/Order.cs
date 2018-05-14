using System;
using System.Collections.Generic;

namespace Week20.A.Two.One
{
    class Order
    {
        public readonly int OrderNumber;
        public readonly Customer Customer;
        public readonly List<Product> Products = new List<Product>();
        
        public Order(int orderNumber, Customer customer)
        {
            OrderNumber = orderNumber;
            Customer = customer;
        }
        
        public DateTime Timestamp { get; private set; }

        public decimal Total
        {
            get
            {
                decimal total = 0;

                foreach (Product product in Products)
                {
                    total += product.Price;
                }

                return total;
            }
        }
        
        public void Complete()
        {
            if (Timestamp == default(DateTime))
            {
                throw new InvalidOperationException("Order was already completed");
            }
            
            Timestamp = DateTime.Now;
        }
    }
}
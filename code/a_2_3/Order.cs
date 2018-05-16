using System;
using System.Collections.Generic;

namespace Week20.A.Two.Three
{
    class Order
    {
        public readonly int OrderNumber;
        public readonly Customer Customer;
        public readonly List<OrderLine> OrderLines = new List<OrderLine>();
        
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

                foreach (OrderLine orderLine in OrderLines)
                {
                    total += orderLine.SubTotal;
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

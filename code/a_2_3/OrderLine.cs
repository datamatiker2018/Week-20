namespace Week20.A.Two.Three
{
    class OrderLine
    {
        public readonly Product Product;
        public int Quantity;
        public readonly decimal PricePerUnit;

        public OrderLine(Product product, int quantity)
            : this(product, quantity, product.Price)
        {
        }
        
        public OrderLine(Product product, int quantity, decimal pricePerUnit)
        {
            Product = product;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        public decimal SubTotal
        {
            get
            {
                return PricePerUnit * Quantity;
            }
        }
    }
}

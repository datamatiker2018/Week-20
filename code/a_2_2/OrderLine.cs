namespace Week20.A.Two.Two
{
    class OrderLine
    {
        public readonly Product Product;
        public int Quantity;

        public OrderLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal SubTotal
        {
            get 
            {
                return Product.Price * Quantity;
            }
        }
    }
}

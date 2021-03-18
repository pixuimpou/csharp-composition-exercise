using System.Globalization;
namespace secao9_exercicioprop.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${subTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

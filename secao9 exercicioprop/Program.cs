using System;
using System.Globalization;
using secao9_exercicioprop.Entities;
using secao9_exercicioprop.Entities.Enums;

namespace secao9_exercicioprop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse < OrderStatus > (Console.ReadLine());
            Console.Write("How many items to this order? ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= itemQuantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(pName, pPrice);
                OrderItem orderItem = new OrderItem(pQuantity, pPrice, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}

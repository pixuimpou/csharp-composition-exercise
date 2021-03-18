using System;
using System.Collections.Generic;
using System.Text;
using secao9_exercicioprop.Entities.Enums;

namespace secao9_exercicioprop.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.Append(Total());
            return sb.ToString();
        }
    }
}

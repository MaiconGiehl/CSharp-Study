using System;
using System.Collections.Generic;
using System.Text;
using EnumerationExercise03.Entities.Enums;

namespace EnumerationExercise03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client) : this()
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        
        public void addItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double Sum = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                return Sum += item.SubTotal();
            }
            return Sum;

        }
        public override string ToString()
        {
            StringBuilder order = new StringBuilder();
            order.Append("ORDER SUMMARY: ");
            order.Append($"\r\nOrder moment: {Moment})");
            order.Append($"\r\nOrder status: {Status}");
            order.Append($"\r\nClient: {Client}");
            order.Append($"\r\nOrder Items: ");
            order.Append($"\r\nTotal Price: ");
            return order.ToString();
        }
    }
}

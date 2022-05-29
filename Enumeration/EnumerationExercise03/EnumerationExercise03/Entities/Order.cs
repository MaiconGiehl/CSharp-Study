using System;
using System.Collections.Generic;
using EnumerationExercise03.Entities.Enums;

namespace EnumerationExercise03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(Client client)
        {
            Client = client;
        }
        
        public void addItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void removeItem (OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double Sum = 0.0;
            foreach(OrderItem item in OrderItems)
            {
                return Sum += item.SubTotal();
            }
            return Sum;
            
        }
        public override string ToString()
        {
            return "ORDER SUMMARY: " +
            $"\r\nOrder moment: " +
            $"\r\nOrder status: " +
            $"\r\nClient: {Client}" +
            $"\r\nOrder Items: " +
            $"\r\nTotal Price: ";
        }
    }
}

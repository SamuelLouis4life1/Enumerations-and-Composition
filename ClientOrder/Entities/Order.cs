using System;
using System.Globalization;
using ClientOrder.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem orderItem in OrderItems)
            {
                sum += orderItem.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Order status: " + OrderStatus);
            stringBuilder.AppendLine("Client: " + Client);
            stringBuilder.AppendLine("Order item: ");
            foreach (OrderItem orderItem in OrderItems)
            {
                stringBuilder.AppendLine(orderItem.ToString());
            }
            stringBuilder.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }
    }
}

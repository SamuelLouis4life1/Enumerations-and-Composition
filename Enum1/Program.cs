using System;
using Enum1.Entities.Enums;
using Enum1.Entities;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // convert enum to string 
            string txt = OrderStatus.PendingPayment.ToString();

            // convert string to enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

            Console.ReadLine();
        }
    }
}

using System;
using ClientOrder.Entities.Enums;
using ClientOrder.Entities;
using System.Globalization;

/// <summary>
/// Read order data with N items (N provided by user).
/// Then show a summary of the order.Note the order instant must be the system instant: DateTime.Now
/// </summary>


namespace ClientOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime BithDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(Name, Email, BithDate);
            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order ? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}

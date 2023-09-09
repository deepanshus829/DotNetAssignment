using ShoppingCart.Model;
using System;
using System.Globalization;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product(1, "Coconut oil", 100, 5);
            Product product2 = new Product(2, "Cream Powder", 150, 10);
            Product product3 = new Product(3, "Guns", 1500, 25);

            // Create a customer 
            Customer customer = new Customer(1001, "NO NAME");

            
            Order order1 = new Order(1);
            order1.LineItems.Add(new LineItem(101, 2) { Product = product1 });
            order1.LineItems.Add(new LineItem(102, 3) { Product = product2 });

            Order order2 = new Order(2);
            order2.LineItems.Add(new LineItem(103, 1) { Product = product3 });

            customer.Orders.Add(order1);
            customer.Orders.Add(order2);

            
            Console.WriteLine(customer.ToString());

        }
    }
}

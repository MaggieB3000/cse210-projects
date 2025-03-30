using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Yarn-Woman", new Address("Fake street", "Phoneyville", "IDK", "US"));
        Customer customer2 = new Customer("Pencil Woman", new Address("rando street", "Cardboard Town", "Unknown", "USA"));

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mohair Yarn", 7546, 4.99, 5));
        order1.AddProduct(new Product("Wool/Alpaca Mix Yarn", 8322, 8.49, 3));
        order1.PackingLabel();
        Console.WriteLine("");
        order1.ShippingLabel();
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: ${order1.CalculatedCost()}");
        Console.WriteLine("");

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Black Fountain Pen", 3958, 9.67, 1));
        order2.AddProduct(new Product("Black Ink Bottle", 5739, 12.35, 1));
        order2.AddProduct(new Product("Charcoal Pencil", 7498, 1.59, 10));
        order2.PackingLabel();
        Console.WriteLine("");
        order2.ShippingLabel();
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: ${order2.CalculatedCost()}");
    }
}
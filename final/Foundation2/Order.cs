using System;
using System.Data.Common;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculatedCost()
    {
        double cost = 0.00;

        foreach (Product i in _products)
        {
            double productCost = i.TotalCost();
            cost = cost + productCost;
        }

        if (_customer.GetIsInUS())
        {
            cost = cost + 5;
        }
        else
        {
            cost = cost + 35;
        }

        return cost;
    }

    public void PackingLabel()
    {
        Console.WriteLine($"Customer: {_customer.GetName()}\nProduct ID:");

        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetFormatedProductID());
        }
    }

    public void ShippingLabel()
    {   
        Console.WriteLine($"Customer: {_customer.GetName()}\nAddress:\n{_customer.GetAdress()}") ;
    }
}
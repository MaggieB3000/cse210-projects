using System;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _shippingCost;

    public double CalculatedCost()
    {
        double cost = 0.00

        foreach (Product i in _products)
        {
            double productCost = i.TotalCost();
            cost = cost + productCost;
        }
    }

    public string PackingLabel()
    {
        string name = _customer.GetName();
        return $"Customer: {name}\nProducts: {_products}"
    }

    public string ShippingLabel()
    {
        '''
        '''figure out the stupid formated address by going through the customer and address class.
        '''
        return $"Customer: {_customer}\nAddress: {address}"
    }
}
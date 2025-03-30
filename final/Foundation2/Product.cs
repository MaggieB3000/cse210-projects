using System;

class Product
{
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetFormatedProductID()
    {
        return _productID.ToString();
    }
}
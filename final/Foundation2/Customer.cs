using System;
using System.Globalization;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetIsInUS()
    {
        return _address.GetIsInUSAddress();
    }

    public string GetAdress()
    {
        return _address.FormatedAddress();
    }

    public string GetName()
    {
        return _name;
    }

}
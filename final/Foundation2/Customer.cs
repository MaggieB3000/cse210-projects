using System;

class Customer
{
    private string _name;
    private Address _address;

    public Address GetAdress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }

}
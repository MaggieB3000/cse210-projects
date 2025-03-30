using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInUS;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        if (_country == "US" || _country == "USA" || _country == "United States" || _country == "United States of America") 
        {
            _isInUS = true;
        }
        else
        {
            _isInUS = false;
        }
         
    }

    public string FormatedAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public bool GetIsInUSAddress()
    {
        return _isInUS;
    }
}
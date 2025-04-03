using System;

abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, string address, string type)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public string StandardDetails()
    {
        return $"Standard Details:\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public string ShortDetails()
    {
        return $"Short Details:\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }

    public abstract string FullDetails();
}
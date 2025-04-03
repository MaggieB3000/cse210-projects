using System;

class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"Full Details:\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nEmail for RSVP: {_email}";
    }
}
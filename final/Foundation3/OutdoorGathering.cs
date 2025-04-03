using System;

class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, string address, string type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        return $"Full Details:\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nWeather: {_weather}";
    }
}
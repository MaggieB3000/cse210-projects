using System;

class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, string address, string type, string speaker, string capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"Full Details:\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
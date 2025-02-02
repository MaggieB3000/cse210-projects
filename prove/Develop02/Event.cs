class Event
{
    private string _prompt;
    private string _response;
    private string _date;

    //Returns a comma seperated list of Event attributes.
    public string Get()
    {
        return _date + "," + _prompt + "," + _response;
    }

    public static Event New(string _date, string _prompt, string _response)
    {
        Event _newEvent = new Event();
        _newEvent._date = _date;
        _newEvent._prompt = _prompt;
        _newEvent._response = _response;

        return _newEvent;
    }

    public static Event Load(string _encoded_entry)
    {
        string[] parts = _encoded_entry.Split(",");

        string _date = parts[0];
        string _prompt = parts[1];
        string _response = parts[2];

        return New(_date, _prompt, _response);
    }

    //Returns a formatted string of attributes.
    public override string ToString()
    {
        return "Date: " + _date + " - Prompt: " + _prompt + "\n" + _response;
    }
}
class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"\nStudent Name: {_studentName}\nTopic: {_topic}";
    }
}
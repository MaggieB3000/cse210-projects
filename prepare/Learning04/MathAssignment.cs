class MathAssignment : Assignment
{
    private string _title;


    public MathAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"\nStudent Name: {_studentName}\nTopic: {_topic}\nTitle: {_title}";
    }
}
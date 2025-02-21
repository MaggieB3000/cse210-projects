class WritingAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public WritingAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"\nStudent Name: {_studentName}\nTopic: {_topic}\nTextbook Section: {_textbookSection}\nProblems: {_problems}";
    }
}
using System;
using System.Net.Mail;
using System.IO;

class Journal
{

    private Event[] _entries;
    private string[] _prompt_List = {
        "Describe your perfect day:",
        "If you had three wishes, what would they be?",
        "What is your greatest fear?",
        "What challenges have you faced today?",
        "What is something that makes you smile?"};

    public Journal()
    {
        _entries = [];
    }

    public Event WriteNewEvent()
    {
        Random _rnd = new Random();
        int _promptIndex = _rnd.Next(0, _prompt_List.Length);
        string _prompt = _prompt_List[_promptIndex];
        Console.WriteLine($"Your prompt: {_prompt}");
        string _userResponse = Console.ReadLine();
        DateTime _theCurrentTime = DateTime.Now;
        string _dateText = _theCurrentTime.ToShortDateString();

        Event _event = Event.New(_dateText, _prompt, _userResponse);

        _entries = _entries.Append(_event).ToArray();

        return _event;
    }

    public void Display()
    {
        foreach (Event _entry in _entries)
        {
            Console.WriteLine(_entry.ToString());
        }
    }

    public void Save()
    {
        Console.WriteLine("Enter a name for your journal: ");
        string _fileName = Console.ReadLine();

        using (StreamWriter _outputFile = new StreamWriter(_fileName))
        {
            foreach (Event _entry in _entries)
            {
                _outputFile.WriteLine(_entry.Get());
            }

        }

        Console.WriteLine($"Saved {_fileName}.");
    }

    public void Load()
    {
        Console.WriteLine("Enter a name for your journal: ");
        string _fileName = Console.ReadLine();

        string[] _lines = System.IO.File.ReadAllLines(_fileName);

        _entries = [];

        foreach (string _line in _lines)
        {
           Event _entry = Event.Load(_line);

           _entries = _entries.Append(_entry).ToArray();
        
        }

    }

    public int Menu()
    {
        Console.WriteLine("Welcome to the journal program!\nPlease choose one of the below options:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

        int _userChoice = int.Parse(Console.ReadLine());

        return _userChoice;
    }
}
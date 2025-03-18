using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Abstract and virtual methods for polymorphism
    public abstract int RecordEvent();
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    
    public virtual string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_name} ({_description})";
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public int GetPoints()
    {
        return _points;
    }
    
    // Method to convert goal to a string that can be saved to a file
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points},{_isComplete}";
    }
}
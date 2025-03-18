using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }
    
    // Constructor for loading from file
    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
}

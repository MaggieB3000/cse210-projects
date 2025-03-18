using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }
    
    // Constructor for loading from file
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
        _isComplete = _timesCompleted >= _target;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        
        if (_timesCompleted >= _target && !_isComplete)
        {
            _isComplete = true;
            return _points + _bonus; // Award points plus bonus
        }
        
        return _points;
    }
    
    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }
    
    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_name} ({_description}) — Completed {_timesCompleted}/{_target} times";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points},{_target},{_bonus},{_timesCompleted}";
    }
}
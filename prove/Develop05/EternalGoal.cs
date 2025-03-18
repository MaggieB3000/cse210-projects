using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points; // Always give points, never complete
    }
    
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points}";
    }
}
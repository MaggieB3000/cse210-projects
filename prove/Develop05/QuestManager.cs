using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class QuestManager
{
    private List<Goal> _goals;
    private int _score;

    public QuestManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public int GetScore()
    {
        return _score;
    }
    
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"Your total score is now {_score}");
        }
    }
    
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }
        
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    
    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // First line is the score
                writer.WriteLine(_score);
                
                // Each subsequent line is a goal
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }
    
    public void LoadGoals(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            
            // First line is the score
            _score = int.Parse(lines[0]);
            _goals.Clear();
            
            // Each subsequent line is a goal
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':', 2);
                string goalType = parts[0];
                string[] goalParts = parts[1].Split(',');
                
                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(
                            goalParts[0], 
                            goalParts[1], 
                            int.Parse(goalParts[2]), 
                            bool.Parse(goalParts[3])
                        );
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(
                            goalParts[0], 
                            goalParts[1], 
                            int.Parse(goalParts[2])
                        );
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(
                            goalParts[0], 
                            goalParts[1], 
                            int.Parse(goalParts[2]), 
                            int.Parse(goalParts[3]), 
                            int.Parse(goalParts[4]), 
                            int.Parse(goalParts[5])
                        );
                        break;
                }
                
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}

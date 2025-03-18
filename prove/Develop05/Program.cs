using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        QuestManager questManager = new QuestManager();
        bool running = true;

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"Current Score: {questManager.GetScore()}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(questManager);
                    break;
                case "2":
                    questManager.DisplayGoals();
                    break;
                case "3":
                    RecordEvent(questManager);
                    break;
                case "4":
                    SaveGoals(questManager);
                    break;
                case "5":
                    LoadGoals(questManager);
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thank you for using the Eternal Quest Program!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(QuestManager questManager)
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be completed? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for completing the entire checklist: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        questManager.AddGoal(goal);
        Console.WriteLine($"Goal '{name}' created successfully!");
    }

    static void RecordEvent(QuestManager questManager)
    {
        List<Goal> goals = questManager.GetGoals();

        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record events for.");
            return;
        }

        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? Enter the number: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= goals.Count)
        {
            questManager.RecordEvent(goalNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals(QuestManager questManager)
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        questManager.SaveGoals(filename);
    }

    static void LoadGoals(QuestManager questManager)
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        questManager.LoadGoals(filename);
    }
}
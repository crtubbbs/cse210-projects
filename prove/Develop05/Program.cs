using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all goals
        List<Goal> _CTGoals = new List<Goal>();

        // Load goals from file if available
        if (File.Exists("goals.txt"))
        {
            _CTGoals = _CTLoadGoalsFromFile("goals.txt");
        }

        // Display menu options
        while (true)
        {
            Console.WriteLine("\nEternal Quest - Goals Tracker");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record Accomplishment");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save Goals and Exit");
            Console.Write("Enter your choice: ");
            string _CTChoice = Console.ReadLine();

            switch (_CTChoice)
            {
                case "1":
                    _CTDisplayGoals(_CTGoals);
                    break;
                case "2":
                    _CTAddNewGoal(_CTGoals);
                    break;
                case "3":
                    _CTRecordAccomplishment(_CTGoals);
                    break;
                case "4":
                    _CTViewScore(_CTGoals);
                    break;
                case "5":
                    _CTSaveGoalsToFile(_CTGoals, "goals.txt");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void _CTDisplayGoals(List<Goal> _CTGoals)
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal _CTGoal in _CTGoals)
        {
            Console.WriteLine(_CTGoal._CTGetGoalStatus());
        }
    }

    static void _CTAddNewGoal(List<Goal> _CTGoals)
    {
        Console.Write("\nEnter the name of the goal: ");
        string _CTName = Console.ReadLine();
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string _CTTypeChoice = Console.ReadLine();

        Goal _CTNewGoal = null;

        switch (_CTTypeChoice)
        {
            case "1":
                Console.Write("Enter the points for completing this goal: ");
                int _CTPoints = int.Parse(Console.ReadLine());
                _CTNewGoal = new SimpleGoal(_CTName, _CTPoints);
                break;
            case "2":
                Console.Write("Enter the points for each time you accomplish this goal: ");
                int _CTEternalPoints = int.Parse(Console.ReadLine());
                _CTNewGoal = new EternalGoal(_CTName, _CTEternalPoints);
                break;
            case "3":
                Console.Write("Enter the total number of times to accomplish this goal: ");
                int _CTTotalTimes = int.Parse(Console.ReadLine());
                Console.Write("Enter the points for each time you accomplish this goal: ");
                int _CTChecklistPoints = int.Parse(Console.ReadLine());
                _CTNewGoal = new ChecklistGoal(_CTName, _CTChecklistPoints, 0, _CTTotalTimes);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                return;
        }

        _CTGoals.Add(_CTNewGoal);
        Console.WriteLine("Goal added successfully!");
    }

    static void _CTRecordAccomplishment(List<Goal> _CTGoals)
    {
        Console.WriteLine("\nSelect a goal to record accomplishment:");
        for (int i = 0; i < _CTGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_CTGoals[i]._CTName}");
        }
        Console.Write("Enter your choice: ");
        int _CTGoalIndex = int.Parse(Console.ReadLine()) - 1;

        _CTGoals[_CTGoalIndex]._CTAccomplish();
        Console.WriteLine($"Accomplishment recorded for {_CTGoals[_CTGoalIndex]._CTName}.");
    }

    static void _CTViewScore(List<Goal> _CTGoals)
    {
        int _CTTotalScore = 0;
        foreach (Goal _CTGoal in _CTGoals)
        {
            _CTTotalScore += _CTGoal._CTScore;
        }
        Console.WriteLine($"\nTotal Score: {_CTTotalScore}");
    }

    static void _CTSaveGoalsToFile(List<Goal> _CTGoals, string _CTFileName)
    {
        using (StreamWriter _CTWriter = new StreamWriter(_CTFileName))
        {
            foreach (Goal _CTGoal in _CTGoals)
            {
                _CTWriter.WriteLine(_CTGoal._CTSerialize());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    static List<Goal> _CTLoadGoalsFromFile(string _CTFileName)
    {
        List<Goal> _CTLoadedGoals = new List<Goal>();
        using (StreamReader _CTReader = new StreamReader(_CTFileName))
        {
            string _CTLine;
            while ((_CTLine = _CTReader.ReadLine()) != null)
            {
                string[] _CTParts = _CTLine.Split(',');
                string _CTName = _CTParts[0];
                int _CTPoints = int.Parse(_CTParts[1]);
                int _CTTimesCompleted = int.Parse(_CTParts[2]);
                string _CTType = _CTParts[3];
                switch (_CTType)
                {
                    case "Simple":
                        _CTLoadedGoals.Add(new SimpleGoal(_CTName, _CTPoints, _CTTimesCompleted));
                        break;
                    case "Eternal":
                        _CTLoadedGoals.Add(new EternalGoal(_CTName, _CTPoints, _CTTimesCompleted));
                        break;
                    case "Checklist":
                        int _CTTotalTimes = int.Parse(_CTParts[4]);
                        _CTLoadedGoals.Add(new ChecklistGoal(_CTName, _CTPoints, _CTTimesCompleted, _CTTotalTimes));
                        break;
                    default:
                        Console.WriteLine("Unknown goal type encountered while loading goals.");
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
        return _CTLoadedGoals;
    }
}
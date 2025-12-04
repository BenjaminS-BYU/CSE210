using System.IO;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public GoalManager()
    {
        
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GetScore() => _score;

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:\n");
        ListGoalNames();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.Write(@$"What Goal is this?

1. Simple Goal
2. Eternal Goal
3. Checklist Goal

Choose: ");

        string type = Console.ReadLine();

        Console.Write("Name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Short description of the goal: ");
        string desc = Console.ReadLine();

        Console.Write("How many points is this goal worth?: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;

            case "3":
                Console.Write("How many times do you want to achieve this goal?: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for achieving the target amount?: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            Console.ReadKey();
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count) return;

        Goal g = _goals[index];

        bool alreadyComplete = g.IsComplete();

        g.RecordEvent();

        _score += g.GetPoints();

        if (!alreadyComplete && g.IsComplete() && g is ChecklistGoal ck)
        {
            _score += ck.GetBonus();
        }

        Console.WriteLine("Event Recorded.");
        Console.ReadKey();
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using StreamWriter sw = new StreamWriter(file);
        sw.WriteLine(_score);

        foreach (Goal g in _goals)
            sw.WriteLine(g.GetStringRepresentation());

        Console.WriteLine("Press enter to save.");
        Console.ReadKey();
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split("|");

            switch (p[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
                    break;

                case "ChecklistGoal":
                    var cg = new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4]), int.Parse(p[5]));
                    cg.LoadAmount(int.Parse(p[6]));
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Loaded.");
        Console.ReadKey();
    }
}
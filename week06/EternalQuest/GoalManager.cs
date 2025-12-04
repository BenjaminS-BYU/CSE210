using System.IO;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;
    private List<string> _pointHistory = new List<string>();


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

        string input = Console.ReadLine();

        if (!int.TryParse(input, out int index))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.ReadKey();
            return;
        }

        index -= 1; // Start at 0 again

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            Console.ReadKey();
            return;
        }


        Goal g = _goals[index];

        bool alreadyComplete = g.IsComplete();

        g.RecordEvent();

        _score += g.GetPoints();
        _pointHistory.Add($"{DateTime.Now} - Earned {g.GetPoints()} points from \"{g.GetName()}\"");

        if (!alreadyComplete && g.IsComplete() && g is ChecklistGoal ck)
        {
            int pts = g.GetPoints();
            _score += pts;
            _pointHistory.Add($"{DateTime.Now} - Earned {pts} points from \"{g.GetName()}\"");

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
        
        sw.WriteLine("#HISTORY#");
        foreach (var h in _pointHistory)
            sw.WriteLine(h);


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
        _pointHistory.Clear();

        int historyStart = Array.IndexOf(lines, "#HISTORY#");

        int goalEnd = historyStart == -1 ? lines.Length : historyStart;

        // Load goals
        for (int i = 1; i < goalEnd; i++)
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

            // Load history
            if (historyStart != -1)
            {
                for (int i = historyStart + 1; i < lines.Length; i++)
                    _pointHistory.Add(lines[i]);
            }

            Console.WriteLine("Loaded.");
            Console.ReadKey();
    }


        public void ShowPointHistory()
    {
        if (_pointHistory.Count == 0)
        {
            Console.WriteLine("No points earned yet.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nPoints Earned History:\n");

        foreach (string entry in _pointHistory)
            Console.WriteLine(entry);

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
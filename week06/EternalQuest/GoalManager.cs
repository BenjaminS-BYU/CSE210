using System.IO;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        int points = _goals[goalIndex].RecordEvent();
        _score += points;
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GetScore() => _score;

    public void Save(string filename)
    {
        using StreamWriter writer = new(filename);
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
                writer.WriteLine(g.GetStringRepresentation());
        }
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;

                case "EternalGoal":
                break;

                case "ChecklistGoal":
                break;
            }
        }
    }
}
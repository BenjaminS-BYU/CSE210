public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
            return GetPoints() + _bonus;

        return GetPoints();

    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} — Completed {_amountCompleted}/{_target}";
    }

    public override string GetStatusSymbol()
    {
        return _amountCompleted >= _target ? "X" : " ";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }
}
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points) // ChatGpt is teaching me about constructor chaining, so I can call the base class's constructor so it'll initialize its own fields, this way I can reuse without accessing the base classes values. 
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }

    public override string GetStatusSymbol()
    {
        return _isComplete ? "x" : " ";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

}
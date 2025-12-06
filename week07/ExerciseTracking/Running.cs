public class Running : Activity
{
    private double _distance;

    public override double GetPace()
    {
        return (double)GetMinutes() / _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public void NewRun(int minutes, double distance)
    {
        Console.WriteLine(GetSummary());
    }
}

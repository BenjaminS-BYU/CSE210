public abstract class Activity
{
    private string _name;
    private string _date;
    private int _minutes;

    public Activity(string name, int minutes, DateTime date)
    {
        _name = name;
        _minutes = minutes;
        _date = date.ToString("MMMM dd, yyyy");
    }

    public string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} mins) - " +
               $"Distance {GetDistance()}, Speed {GetSpeed()} kph, " +
               $"Pace {GetPace()} min per km.";
    }

    public int GetMinutes() => _minutes;

    public virtual double GetPace() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetDistance() => 0;
}

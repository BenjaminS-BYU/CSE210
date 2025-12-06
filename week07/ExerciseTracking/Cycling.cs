public class Cycling : Activity
{
    private double _speed; // kph

    public Cycling(DateTime date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speed = speedKph;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

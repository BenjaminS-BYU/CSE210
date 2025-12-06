public class Cycling : Activity
{
    private double _speed;
    private double _pace;

    public override double GetSpeed()
    {
        return 60 / _pace;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
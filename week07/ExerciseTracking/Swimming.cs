public class Swimming : Activity
{
    private int _numOfLaps;

    public override double GetDistance()
    {
        return _numOfLaps * 50/1000;
    }
}
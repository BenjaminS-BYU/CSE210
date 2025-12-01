public class Circle : Shape
{
    private double _radius;

    public override double GetArea()
    {
        return _radius*2 * Math.PI;
    }
}
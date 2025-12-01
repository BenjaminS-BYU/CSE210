public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public override double GetArea()
    {
        return _length * _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public void SetLength(double length)
    {
        _length = length;
    }
}
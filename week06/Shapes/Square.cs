public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        return _side * 4;
    }   

    public void SetSide(double side)
    {
        _side = side;
    }


}
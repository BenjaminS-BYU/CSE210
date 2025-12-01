using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetSide(4);
        double sArea = square.GetArea();
        Console.WriteLine($"The area of the square is {sArea}");

        Rectangle rectangle = new Rectangle();
        rectangle.SetLength(4);
        rectangle.SetWidth(2);
        double rArea = rectangle.GetArea();
        Console.WriteLine($"The area of the rectangle is {rArea}");

        Circle circle = new Circle();
        circle.SetRadius(4);
        double cArea = circle.GetArea();
        Console.WriteLine($"The area of the circle is {cArea}");
    }
}
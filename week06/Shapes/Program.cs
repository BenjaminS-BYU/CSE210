using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square square = new();
        square.SetColor("Blue");
        square.SetSide(4);

        Rectangle rectangle = new();
        rectangle.SetColor("Green");
        rectangle.SetLength(4);
        rectangle.SetWidth(2);

        Circle circle = new();
        circle.SetColor("Red");
        circle.SetRadius(4);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"The color for {sh} is {sh.GetColor()}");
            Console.WriteLine($"The area for {sh} is {sh.GetArea():F2}\n");
            Thread.Sleep(1000);
        }
    }
}
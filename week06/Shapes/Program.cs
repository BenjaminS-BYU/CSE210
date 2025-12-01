using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetSide(4);
        double sArea = square.GetArea();
        Console.WriteLine($"The area of the square is {sArea}");
    }
}
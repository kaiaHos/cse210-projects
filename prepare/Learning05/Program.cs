using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(7.5, "green");
        shapes.Add(square);
        Rectangle rectangle = new Rectangle(3,4,"blue");
        shapes.Add(rectangle);
        Circle circle = new Circle(5, "yellow");
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
        
        //Console.WriteLine("Hello Learning05 World!");
    }
}
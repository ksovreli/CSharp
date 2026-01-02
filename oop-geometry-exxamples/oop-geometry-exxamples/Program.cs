using TenthConsoleApp;
using TenthConsoleApp.models;

Shape[] shapes = new Shape[]
{
    new Triangle(3, 4),
    new Rectangle(4, 5),
    new Circle(6)
};

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Area is {shape.Area()}");
}
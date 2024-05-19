using ShapeLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        Shape someShape1 = new Triangle(3, 4, 5);
        Shape someShape2 = new Circle(3.5);

        Console.WriteLine(string.Format("Площадь фигуры 1, {0:f2}", someShape1.GetArea()));
        Console.WriteLine(string.Format("Площадь фигуры 2, {0:f2}", someShape2.GetArea()));
    }
}
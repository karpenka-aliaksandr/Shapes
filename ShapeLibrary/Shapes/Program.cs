using ShapeLibrary;

using Shapes;

int radius = 5,
    firstSide = 3,
    secondSide = 4,
    thirdSide = 5;

Shape someShape1 = new Triangle (4, 5, 6);
Shape someShape2 = new Circle(3.5);

Console.WriteLine(string.Format("Площадь фигуры 1, {0:f2}", someShape1.GetArea()));
Console.WriteLine(string.Format("Площадь фигуры 2, {0:f2}", someShape2.GetArea()));
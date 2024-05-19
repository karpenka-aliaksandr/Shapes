namespace ShapeLibrary;

public class Triangle : Shape
{
    private double _firstSide;
    private double _secondSide;
    private double _thirdSide;

    public Triangle (double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public override double GetArea()
    {
        double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

        //Расчет площади треугольника по трем сторонам (формула Герона)
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide)
                                       * (semiPerimeter - _secondSide)
                                       * (semiPerimeter - _thirdSide));
    }
}

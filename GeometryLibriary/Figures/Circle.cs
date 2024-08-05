namespace GeometryLibrary;

public class Circle(double radius) : IFigure
{
    private double Radius { get; } = radius;

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
using System.Diagnostics.SymbolStore;

namespace GeometryLibrary;

public class Triangle : IFigure
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    private const double eps = 0.00001;

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new Exception($"Invalid sides for Triangle: в Евглидовой геометрии нет треугольника со сторонами {sideA}, {sideB}, {sideC}");
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
   
    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        // Неравенство треугольника: сумма любых двух сторон должна быть больше третьей стороны
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
    public bool IsRightTriangle()
    {
        // Теорема Пифагора: a^2 + b^2 = c^2
        double[] sides = new double[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < eps; // Tolerance for floating point comparison
    }
}
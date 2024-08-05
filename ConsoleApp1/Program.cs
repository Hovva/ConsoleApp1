

using System.ComponentModel.Design;
using GeometryLibrary;

List<IFigure> figures = new List<IFigure>()
{
    new Circle(3),
    new Triangle(3, 4, 5),
    new Triangle(3, 6, 8)

};
Console.WriteLine("==========================");
foreach (var v in figures)
{
    Console.WriteLine("Площадь:" + v.CalculateArea());
    switch (v)
    {
        case Triangle triangle:
        {
            Console.Write("Это треугольник");
            Triangle t = triangle;
            if (t.IsRightTriangle())
                Console.Write("[еще и прямоугольный]");
            Console.WriteLine();
            break;
        }
        case Circle:
            Console.WriteLine("Ну, круг и круг, че бухтеть то");
            break;
    }
    Console.WriteLine("==========================");
}





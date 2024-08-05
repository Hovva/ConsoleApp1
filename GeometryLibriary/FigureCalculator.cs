using System;

namespace GeometryLibrary
{
  

    public static class FigureCalculator
    {
        public static double CalculateArea(FigureType figureType, params double[] parameters)
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    if (parameters.Length != 1)
                        throw new ArgumentException("Circle requires one parameter: radius.");
                    return new Circle(parameters[0]).CalculateArea();
                case FigureType.Triangle:
                    if (parameters.Length != 3)
                        throw new ArgumentException("Triangle requires three parameters: sideA, sideB, sideC.");
                    return new Triangle(parameters[0], parameters[1], parameters[2]).CalculateArea();
                default:
                    throw new ArgumentException("Unsupported figure type.");
            }
        }
    }
}
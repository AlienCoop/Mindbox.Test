namespace Mindbox.Test.Figures;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Длины сторон треугольника не могут быть отрицательными");

        if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            throw new ArgumentException("Треугольник с такими сторонами не существует.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    ///  Считает площадь по формуле Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC), где s - полупериметр
    /// </summary>
    /// <returns>Возвращает площадь треугольника</returns>
    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Определяет, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns> Возвращает true, если треугольник является прямоугольным. false, если нет</returns>
    public bool IsRightTriangle()
    {
        return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
               Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2) ||
               Math.Pow(SideC, 2) + Math.Pow(SideA, 2) == Math.Pow(SideB, 2);
    }
}
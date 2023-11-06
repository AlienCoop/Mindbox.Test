namespace Mindbox.Test.Figures;

public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if(radius <= 0)
            throw new ArgumentException("Радиус круга должен быть положительным числом.", nameof(radius));
        Radius = radius;
    }
    /// <summary>
    ///  Считает площадь по формуле PI * Radius * Radius
    /// </summary>
    /// <returns>Возвращает площадь круга</returns>
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
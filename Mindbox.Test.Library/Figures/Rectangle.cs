namespace Mindbox.Test.Figures;

public class Rectangle : IFigure
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Ширина и высота прямоугольника должны быть положительными");

        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
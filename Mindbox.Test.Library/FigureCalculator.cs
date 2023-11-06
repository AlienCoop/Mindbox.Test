namespace Mindbox.Test;
/// <summary>
/// Отвечает за вычисление площади фигуры без знания типа фигуры в compile-time
/// </summary>
public class FigureCalculator
{
    public static double CalculateArea(IFigure figure)
    {
        if (figure is null)
            throw new ArgumentNullException(nameof(figure), "Фигура не может быть пустой.");
        return figure.CalculateArea();
    }
}
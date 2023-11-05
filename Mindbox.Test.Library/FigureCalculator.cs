namespace Mindbox.Test;

public class FigureCalculator
{
    public static double CalculateArea(IFigure figure)
    {
        if (figure is null)
            throw new ArgumentNullException(nameof(figure), "Фигура не может быть пустой.");
        return figure.CalculateArea();
    }
}
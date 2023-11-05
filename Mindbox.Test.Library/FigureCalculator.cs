namespace Mindbox.Test;

//Дополнительный уровень абстракции.
//Без него можно спокойно обойтись, вызывая метод CalculateArea напрямую у фигур.

public class FigureCalculator
{
    public static double CalculateArea(IFigure figure)
    {
        if (figure is null)
            throw new ArgumentNullException("Фигура не может быть пустой.", nameof(figure));
        return figure.CalculateArea();
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Test.Figures;

namespace Mindbox.Test.Tests;

[TestClass]
public class FigureCalculatorTests
{

    [TestMethod]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        IFigure rectangle = new Rectangle(4, 6);
        IFigure circle = new Circle(5);

        double expectedTriangleArea = 6;
        double expectedRectangleArea = 24;
        double expectedCircleArea = 78.54;
        
        double actualTriangleArea = FigureCalculator.CalculateArea(triangle);
        double actualRectangleArea = FigureCalculator.CalculateArea(rectangle);
        double actualCircleArea = FigureCalculator.CalculateArea(circle);

        Assert.AreEqual(expectedTriangleArea, actualTriangleArea, Consts.Delta);
        Assert.AreEqual(expectedRectangleArea, actualRectangleArea, Consts.Delta);
        Assert.AreEqual(expectedCircleArea, actualCircleArea, Consts.Delta);
    }

#nullable disable
    [TestMethod]
    public void CalculateArea_NullFigure_ThrowsArgumentNullException()
    {
        IFigure nullFigure = null;

        Assert.ThrowsException<ArgumentNullException>(() => FigureCalculator.CalculateArea(nullFigure));
    }
#nullable restore

}
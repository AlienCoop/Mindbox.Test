using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Test.Figures;

namespace Mindbox.Test.Tests;

[TestClass]
public class FiguresTests
{

    [TestMethod]
    public void TriangleAreaCalculation_ValidTriangle_ReturnsCorrectArea()
    {
        Triangle triangle = new(3, 4, 5);
        double expectedArea = 6;
        double actualArea = triangle.CalculateArea();
        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void RectangleAreaCalculation_ValidRectangle_ReturnsCorrectArea()
    {
        Rectangle rectangle = new(4, 6);
        double expectedArea = 24;
        double actualArea = rectangle.CalculateArea();
        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void CircleAreaCalculation_ValidCircle_ReturnsCorrectArea()
    {
        Circle circle = new(5);
        double expectedArea = 78.54;
        double actualArea = circle.CalculateArea();
        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void TriangleAreaCalculation_UnvalidTriangle_ThrowsArgumentException()
    {

    }

    [TestMethod]
    public void CircleAreaCalculation_UnvalidCircle_ThrowsArgumentException()
    {

    }

    [TestMethod]
    public void RectangleAreaCalculation_UnvalidRectangle_ThrowsArgumentException()
    {

    }
}
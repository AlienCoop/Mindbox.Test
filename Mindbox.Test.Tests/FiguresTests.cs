using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Test.Figures;

namespace Mindbox.Test.Tests;

[TestClass]
public class FiguresTests
{

    [TestMethod]
    public void Triangle_AreaCalculation_ValidTriangle_ReturnsCorrectArea()
    {
        Triangle triangle = new(3, 4, 5);
        double expectedArea = 6;

        double actualArea = triangle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void Rectangle_AreaCalculation_ValidRectangle_ReturnsCorrectArea()
    {
        Rectangle rectangle = new(4, 6);
        double expectedArea = 24;

        double actualArea = rectangle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void Circle_AreaCalculation_ValidCircle_ReturnsCorrectArea()
    {
        Circle circle = new(5);
        double expectedArea = 78.54;

        double actualArea = circle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, Consts.Delta);
    }

    [TestMethod]
    public void Triangle_AreaCalculation_UnvalidTriangle_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 5, 10));
    }

    [TestMethod]
    public void Circle_AreaCalculation_UnvalidCircle_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(0));
    }

    [TestMethod]
    public void Rectangle_AreaCalculation_UnvalidRectangle_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => new Rectangle(3,-1));
    }

    [TestMethod]
    public void Triangle_IsRightTriangleCheck_RightTriangle_ReturnsTrue()
    {
        Triangle triangle = new(3, 4, 5);

        var check = triangle.IsRightTriangle();

        Assert.AreEqual(true, check);
    }

    [TestMethod]
    public void Triangle_IsRightTriangleCheck_NotRightTriangle_ReturnsFalse()
    {
        Triangle triangle = new(3, 3, 3);

        var check = triangle.IsRightTriangle();

        Assert.AreEqual(false, check);
    }
}
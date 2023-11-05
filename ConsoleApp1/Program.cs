using Mindbox.Test;
using Mindbox.Test.Figures;

var circle = new Circle(5);
var triangle = new Triangle(3, 4, 5);
var rectangle = new Rectangle(5, 5);

var isRignt = triangle.IsRightTriangle();

var circleRadius = FigureCalculator.CalculateArea(circle);
var triangleRadius = FigureCalculator.CalculateArea(triangle);
var rectangleRadius = FigureCalculator.CalculateArea(rectangle);

Console.WriteLine(circleRadius);
Console.WriteLine(isRignt);
Console.WriteLine(triangleRadius);
Console.WriteLine(rectangleRadius);
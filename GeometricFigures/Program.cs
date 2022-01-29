using GeometricFigures;
using GeometricFigures.Figures;
using System.Reflection;

var array = new Primitive[]
{
    new Circle(2,6),
    new Ellipse(2,6),
    new IsoscelesRightTriangle(2,6),
    new Square(2,6),
};

foreach(var item in array)
{
    Console.WriteLine(item.ToString());
}

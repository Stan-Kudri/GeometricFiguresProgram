using GeometricFigures;
using GeometricFigures.Figures;
using System.Reflection;

Circle circle = new Circle(2, 6);
Primitive primitive = new Square(2, 6);
Console.WriteLine(primitive.Name);
Console.WriteLine(primitive.Area);
Console.WriteLine(primitive.ToString());
primitive.A = 4;
Console.WriteLine(primitive.Name);
Console.WriteLine(primitive.Area);
Console.WriteLine(primitive.ToString());
Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(Primitive)).ToArray();
Primitive[] array = new Primitive[types.Length];

using GeometryLibrary;

IShape circle = new Circle (radius: 5);
double circleArea = circle.CalculateArea();
Console.WriteLine($"Площадь круга: {circleArea}");

IShape triangle = new Triangle(sideA: 3, sideB: 4, sideC: 5); ;
double triangleArea = triangle.CalculateArea();
Console.WriteLine($"Площадь треугольника: {triangleArea}");
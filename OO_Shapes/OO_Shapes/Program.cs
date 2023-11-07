using OO_Shapes;

var Quad1 = GeometricShapeFactory.CreateInstance(3, 4, 5, 6);
var Rec1 = GeometricShapeFactory.CreateInstance(3, 5);
var Sq1 = GeometricShapeFactory.CreateInstance(5);

Console.WriteLine(Quad1.Perimeter());
Console.WriteLine(Rec1.Area());
Console.WriteLine(Rec1.Perimeter());

Console.WriteLine($"The perimeter of the square is {Sq1.Perimeter()}");
Console.WriteLine($"The area of the square is {Sq1.Area()}");

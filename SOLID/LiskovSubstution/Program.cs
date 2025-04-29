// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

Rectangle rect  = new Rectangle();
rect.Width = 10;
rect.Height = 8;

Console.WriteLine(rect.GetArea());

Square square = new Square();
square.Edge = 10;
Console.WriteLine(square.GetArea());

var rect2 = new Geometry().GetRect(20);
//rect2.Width = 5;
//rect2.Height = 15;

Console.WriteLine(rect2.GetArea());
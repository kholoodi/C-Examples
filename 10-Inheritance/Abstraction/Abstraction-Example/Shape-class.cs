using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    // declaring abstract class
  abstract class Shape{
    // declaring abstract methods
    public abstract double Circumference();
    public abstract double Area();
    public abstract void ShapeInfo();
  }// end abstract class
	  
  class ShapeTest
	{
		public static void Main(string[] args)
		{
		  Console.WriteLine("----Circle----");
		  Circle circle1 = new Circle(5);
		  circle1.ShapeInfo();
		  Console.WriteLine("\n----Rectangle----");
		  Rectangle rectangle1 = new Rectangle(5,10);
		  rectangle1.ShapeInfo();
		  Console.WriteLine("\n----Triangle----");
		  Triangle triangle1 = new Triangle(2,3,5);
		  triangle1.ShapeInfo();
		  Console.WriteLine("\n----Square----");
		  Square square1 = new Square(3);
		  square1.ShapeInfo();
		}
	}
  
}

/*Output:

----Circle----
Circle number is:1
Circle circumference is:31.4
Circle Area is:78.5

----Rectangle----
Rectangle number is:1
Rectangle circumference is:100
Rectangle Area is:50

----Triangle----
Triangle number is:1
Triangle circumference is:8
Triangle Area is:0

----Square----
Square number is:1
Square circumference is:6
Square Area is:
*/
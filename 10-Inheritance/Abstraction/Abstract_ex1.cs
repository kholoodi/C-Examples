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
    public abstract double Volume();
    public abstract void ShapeInfo();
  }// end abstract class
	
	class Circle:Shape {
    public static int circle_num = 0; 
  	public double redius;
       public Circle (){
      circle_num++;
    }
    public Circle (double r){
      redius = r;
      circle_num++;
    }
  	public override double Circumference(){ return 2 * 3.14 * redius; }
  	public override double Area() {return 3.14 * redius * redius; }
    public override double Volume(){ return 4*3.14 * redius * redius* redius/3;}
    public override void ShapeInfo(){
        Console.WriteLine("Circle number is:"+ circle_num);
        Console.WriteLine("Circle circumference is:{0}", Circumference());
        Console.WriteLine("Circle Area is:{0}", Area());
        Console.WriteLine("Circle Volume is:{0}", Volume());
    }
  }//end class Circle
  class ShapeTest
	{
		public static void Main(string[] args)
		{
		  Circle circle1 = new Circle(5);
		  circle1.ShapeInfo();
		}
	}
  
}
/*
Output:

Circle number is:1
Circle circumference is:31.4
Circle Area is:78.5
Circle Volume is:523.333333333333

*/
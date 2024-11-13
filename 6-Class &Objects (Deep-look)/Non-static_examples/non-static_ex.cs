using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Cericles
{
	public class CircleTest
	{
		public static void Main(string[] args)
		{
		  //Create the first object 
		  Circle circle1 = new Circle();
		//Access to non-static members via object 
		  circle1.redius = 5.0;
		  circle1.CircleInfo();
		  //Create the second object 
		  Circle circle2 = new Circle(3.0);
		  circle2.CircleInfo();	
		}
	}//end class CircleTest
    public class Circle
  {
    //declaring instance variables 
    public int circle_num = 0; 
  	public double redius; //radius of circle
	//constructos
  	public Circle (){
      circle_num++;
    }
    public Circle (double r){
      redius = r;
      circle_num++;
    }
  	//Non-Static Methods for calculate circumference and area 
  	private double Circumference() { return 2 * 3.14 * redius; }
  	private double Area() {	return 3.14 * redius * redius;}
    //A non-static method for printing the output
    public void CircleInfo(){
      Console.WriteLine("Circle number is:{0}\nCircle circumference is :{1}\nCircle area is:{2}", circle_num , Circumference() ,Area());
    }
  }
}
/*
Output:

Circle number is:1
Circle circumference is :31.4
Circle area is:78.5
Circle number is:1
Circle circumference is :18.84
Circle area is:28.26

*/
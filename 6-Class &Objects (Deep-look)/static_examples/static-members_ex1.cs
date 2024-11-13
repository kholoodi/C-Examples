using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Cericles
{
	public class Circle
  {
    //declaring  static variables
    private static int circle_num = 0; 
  	public static double redius;
    //constructos
    public Circle (){
      circle_num++;
    }
    public Circle (double r){
      redius = r;
      circle_num++;
    }
  	//Static Methods for calculate circumference and area 
  	private static double Circumference() { return 2 * 3.14 * redius; }
  	private static double Area()  {return 3.14 * redius * redius; }
    //A static method for printing the output
    public static void CircleInfo(){
      Console.WriteLine("Circle number is:{0}\nCircle circumference is:{1}\nCircle area is:{2}", circle_num , Circumference() ,Area());
    }
  }//end class Circle
  class CircleTest
	{
		public static void Main(string[] args)
		{
		  //Create thefirst object 
		  Circle circle1 = new Circle(5);
		  //call the static method via class name  
		  Circle.CircleInfo();
		  //Create the second object 
		  Circle circle2 = new Circle();
      //Access to static vriables
      Circle.redius = 3;
		  Circle.CircleInfo();	
		}
	}
  
}
/*
Output:

Circle number is:1
Circle circumference is:31.4
Circle area is:78.5
Circle number is:2
Circle circumference is:18.84
Circle area is:28.26
*/
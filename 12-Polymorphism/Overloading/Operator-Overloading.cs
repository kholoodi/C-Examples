using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismApp
{ //Operator Overloading
	public class App
	{
		public static void Main(string[] args)
		{
			Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
			Rectangle rectangle3 = new Rectangle();

            //Dimensions and area of ​​the first rectangle
            rectangle1.Length = 2.3;
            rectangle1.Width = 5.1;
            Console.WriteLine("Area of rectangle1 is: "+ rectangle1.Area());
            //Dimensions and area of ​​the second rectangle
            rectangle2.Length = 3.2;
            rectangle2.Width = 6.4;
            Console.WriteLine("Area of rectangle2 is: "+ rectangle2.Area());
             //Dimensions and area of ​​the third rectangle
             rectangle3 = rectangle1 + rectangle2;
            Console.WriteLine("Area of rectangle3 is: "+ rectangle3.Area());
		}
	}
	class Rectangle
	{
        private double length;
        private double width;

	  public double Length {
	    get {return length;}
        set {length = value;}
	  } 
	  public double Width {
        get {return width;}
        set {width = value; }
      	  }
	  public double Area (){
	    return length * width;
	  } 
      //Create the operator of rectangle class to to add two Rectangle objects
      public static Rectangle operator+ (Rectangle a, Rectangle b){
        Rectangle rect_x = new Rectangle();
        rect_x.Length = a.Length + b.Length;
        rect_x.Width = a.Width + b.Width;
        return rect_x;
      }
	}
	
}
/*
Output:

Area of rectangle1 is: 11.73
Area of rectangle2 is: 20.48
Area of rectangle3 is: 63.25

*/
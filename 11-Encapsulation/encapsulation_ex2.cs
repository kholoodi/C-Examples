using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
The Rectangle class has attributes length and width and the each of of them has defaults vaule = 1. 
The class include a constructor that reads in the two attributes, and properties for both length and width.
The set accessors should verify that length and width are each floating-point numbers grater than 1.0  and less than 20.0
The class must proived a ways to calculate the Perimter and Area of the rectangle. 
**/
namespace App
{
  public class Rectangle{
    //private class attributes 
    private double length;
    private double width;
    
    //constructors
    public Rectangle (){
      length = 1.0;
      width = 1.0;
    }
    public Rectangle (double theLength , double theWidth){
      length = theLength;
      width = theWidth;
    }
    //Properties
    //The property of length
    public double Length {
      get{ return length;}
      set { length = ( value > 0.0 && value < 20.0 ? value : 1.0);}
      }
      //The property of width
    public double Width {
      get { return width;}
      set { width = (value > 0.0 && value < 20.0 ? value : 1.0);}
    }
    // Using properties for calculate the Perimter and Area
    public double Perimter {
      get { return 2*length + 2* width ;}
    }
    public double Area {
      get { return  length * width;}
    }
    //Public methods
    public override string ToString(){
      return string.Format( "{0} : {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
      "Length", Length, "Width", Width,"Perimeter", Perimter, "Area", Area);
    }
  }
	public class Program
	{
		public static void Main(string[] args)
		{
		  Rectangle rectangle0 = new Rectangle(2.0, 4.0); 
		   Console.WriteLine(rectangle0.ToString());
		}
	}
}
/**
Output:

Length : 2
Width: 4
Perimeter: 12
Area: 8
**/
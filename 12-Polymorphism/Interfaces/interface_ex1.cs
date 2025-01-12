using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
 
	interface Circumference {double circumference();}
	interface Area { double area();}
	class Shape {
	public virtual void display(){
		Console.WriteLine("display() method of class Shape");
		}
	}
	class Square:Circumference,Area {
		public double length;
		public Square (double l)
		{ length = l; }
		public double circumference()
	  		{ return 2 * length;  }
		public double area()
	  		{ return length * length;}
        public void display()
        {
            Console.WriteLine("Square area :{0}\nSquare circumference :{1}",area(), circumference());
        }
    }
	class Rectangle:Shape,Circumference,Area {
		public double length;
		public double Width;
		public Rectangle (double l, double w){
			length = l;
			Width = w;
    	}
		public double circumference()
	  		{ return 2 * (length * Width); }
		public double area()
	  		{ return length * Width;}
        public override void display()
        {
            Console.WriteLine("Rectangle area :{0}\nRectangle circumference :{1}",area(), circumference());
        }
    }
	
	class program {
		public static void Main(string[] args) {
			Square seq1 = new Square(4);
			Rectangle rec1 = new Rectangle(2,3);
			seq1.display();
			rec1.display();
		} 
	}
}
/*
Output:

Square area :16
Square circumference :8
Rectangle area :6
Rectangle circumference :12

*/
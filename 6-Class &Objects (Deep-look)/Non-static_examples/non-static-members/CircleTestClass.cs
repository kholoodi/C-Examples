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
	}
}
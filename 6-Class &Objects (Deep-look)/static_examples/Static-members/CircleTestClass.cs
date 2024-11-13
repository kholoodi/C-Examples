using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Cericles
{
	class CircleTest
	{
		public static void Main(string[] args)
		{
			//Create the first object 
			Circle circle1 = new Circle(5);
			//call the static method via class name  
			Circle.CircleInfo();
			//Create second object 
			Circle circle2 = new Circle();
			//Access to static vriables
			Circle.redius = 3;
			Circle.CircleInfo();	
		}
	}
}
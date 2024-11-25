using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
	class Rectangle:Shape {
    public static int Rectangle_num = 0; 
  	public double length;
    public double Width;
       public Rectangle (){
      Rectangle_num++;
    }
    public Rectangle (double l, double w){
      length = l;
      Width = w;
      Rectangle_num++;
    }
  	public override double Circumference(){ return 2 * (length * Width); }
  	public override double Area() {return length * Width; }
    public override void ShapeInfo(){
        Console.WriteLine("Rectangle number is:"+ Rectangle_num);
        Console.WriteLine("Rectangle circumference is:{0}", Circumference());
        Console.WriteLine("Rectangle Area is:{0}", Area());
    }
  }//end class Rectangle

}

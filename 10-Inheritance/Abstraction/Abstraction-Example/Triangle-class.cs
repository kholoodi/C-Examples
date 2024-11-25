using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
	class Triangle:Shape {
    public static int Triangle_num = 0; 
  	public double t_base;
    public double t_high;
    public double x;
       public Triangle (){
      Triangle_num++;
    }
    public Triangle (double p, double h, double a){
      t_base = p;
      t_base = h;
      x = a;
      Triangle_num++;
    }
  	public override double Circumference(){ return t_base + t_high + x; }
  	public override double Area() {return (1/2) * (t_base * t_high); }
    public override void ShapeInfo(){
        Console.WriteLine("Triangle number is:"+ Triangle_num);
        Console.WriteLine("Triangle circumference is:{0}", Circumference());
        Console.WriteLine("Triangle Area is:{0}", Area());
    }
  }//end class Triangle

}

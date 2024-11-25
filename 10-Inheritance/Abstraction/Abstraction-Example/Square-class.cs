using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
	class Square:Shape {
    public static int Square_num = 0; 
  	public double x;
    public Square (){
      Square_num++;
    }
    public Square (double a){
      x = a;
      Square_num++;
    }
  	public override double Circumference(){ return 2 * x; }
  	public override double Area() {return x * x; }
    public override void ShapeInfo(){
        Console.WriteLine("Square number is:"+ Square_num);
        Console.WriteLine("Square circumference is:{0}", Circumference());
        Console.WriteLine("Square Area is:{0}", Area());
    }
  }//end class Square

}

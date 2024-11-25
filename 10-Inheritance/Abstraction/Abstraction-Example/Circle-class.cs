using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
	class Circle:Shape {
    public static int circle_num = 0; 
  	public double redius;
       public Circle (){
      circle_num++;
    }
    public Circle (double r){
      redius = r;
      circle_num++;
    }
  	public override double Circumference(){ return 2 * 3.14 * redius; }
  	public override double Area() {return 3.14 * redius * redius; }
    public override void ShapeInfo(){
        Console.WriteLine("Circle number is:"+ circle_num);
        Console.WriteLine("Circle circumference is:{0}", Circumference());
        Console.WriteLine("Circle Area is:{0}", Area());
    }
  }//end class Circle
  
}

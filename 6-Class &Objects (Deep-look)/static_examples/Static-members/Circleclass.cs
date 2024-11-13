//A Circle class has static memeber 
using System;
namespace Cericles{
  public class Circle
  {
    //declare static variables
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
  }
}

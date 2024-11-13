//A Circle class has non static memeber 
using System;
namespace Cericles{
  public class Circle
  {
    //declarin ga instance variables 
    public int circle_num = 0; 
  	public double redius; //radius of circle
    //constructos
  	public Circle (){
      circle_num++;
    }
    public Circle (double r){
      redius = r;
      circle_num++;
    }
  	//Non-Static Methods for calculate circumference and area 
  	private double Circumference() { return 2 * 3.14 * redius; }
  	private double Area() {	return 3.14 * redius * redius;}
    //A non-static method for printing the output
    public void CircleInfo(){
      Console.WriteLine("Circle number is:{0}\nCircle circumference is :{1}\nCircle area is:{2}", circle_num , Circumference() ,Area());
    }
  }
}

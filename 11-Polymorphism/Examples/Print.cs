using System;
using FlatShapes;
using Volumes;
namespace Print
{
	class Exercise {
	static void Show (Circle round) {
	    Console.WriteLine("Circle Characteristics");
	    Console.WriteLine("Side: {0}",round.Radius );
	    Console.WriteLine("Diameter:{0}" , round.Diameter);
	    Console.WriteLine("Circumference: {0}", round.Circumference);
	    Console.WriteLine("Area: {0}" ,round.Area);
	  }
	static void Show (Sphere ball){
	    Console.WriteLine("\nSphere Characteristics");
	    Console.WriteLine("Side: {0}",ball.Radius );
	    Console.WriteLine("Diameter:{0}" , ball.Diameter);
	    Console.WriteLine("Circumference: {0}", ball.Circumference);
	    Console.WriteLine("Area: {0}" ,ball.Area);
	    Console.WriteLine("Volume: {0}" ,ball.Volume);
	  }
    public static void Main(string[] args) {
        FlatShapes.Circle c = new FlatShapes.Circle();
        Volumes.Sphere s = new Volumes.Sphere();
        c.Radius = 20.25;
        Show(c);
        s.Radius = 20.25;
        Show(s);
        }//end Main
        }//end class Exercise
}//end namespace Print

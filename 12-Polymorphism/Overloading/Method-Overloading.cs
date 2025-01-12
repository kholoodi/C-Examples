using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismApp
{ //Method Overloading
	public class App
	{
		public static void Main(string[] args)
		{
			Printdata print1 = new Printdata();
			print1.print(5);
			print1.print("Hello");
			print1.print(4.5);
			
		}
	}
	 class Printdata
	{
	  public void print (int x){
	    Console.WriteLine("print an integer number: "+ x);
	  } 
	  public void print (double x){
	    Console.WriteLine("print a float number: " + x);
	  }
	  public void print (string x){
	    Console.WriteLine("print a string: "+ x);
	  } 
	}
	
}
/*
Output:

print an integer number: 5
print a string: Hello
print a float number: 4.5
*/
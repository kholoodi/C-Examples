//Fig 7.9  MethodOverload 
//Overloaded method declarations
using System;
public class MethodOverload{
	//test overload square methods

	public static void Main( string[] args)
	{
		Console.WriteLine("Square of integer 3 is {0}", Square(3));
		Console.WriteLine("Square of double 3.5 is {0}", Square(3.5));

	}//end main

	//square method with int argument 
	public static int Square( int intVaule)
	{
		Console.WriteLine("Called square with int argument: {0}", intVaule);
		return intVaule * intVaule;
	}// end method Square with int argument 
	
	//square method with double argument 
	public static double Square( double doubleVaule)
	{
		Console.WriteLine("Called square with double argument: {0}", doubleVaule);
		return doubleVaule * doubleVaule;
	}// end method Square with double argument 

	}//end class MethodOverload
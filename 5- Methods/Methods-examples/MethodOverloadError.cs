//Fig 7.15 Overloaded 
//Overloaded methods with identical signatures  
//cause compilation errors, if return types are different.
using System;
public class MethodOverloadError{
	// declaration of method Square with int argument 
	public int Square( int x)
	{
		return x * x;
	}
	//second declaration with int argument 
	//cause compilation error even through return types are different
	public static double Square( int  x)
	{
		return x * x;
	}
}
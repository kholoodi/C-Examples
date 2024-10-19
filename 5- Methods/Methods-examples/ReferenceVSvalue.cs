
//Fig 7.18 Reference and output parameters
//Reference, output and parameters
using System;
public class ReferenceAndOutputParameters{
	
	public static void Main( string[] args)
	{
		//call method with refernce, output and value parameters
			int y =  5; 	//initialize y to 5 
			int z ;	//declares z but does not initialize it 

			//display original values of y and z 
			Console.WriteLine("Original value of y : {0}" ,y );
			Console.WriteLine("Original value of z : uninitialized\n " );

			//passs y and z by reference 
			SquareRef( ref y);		//must use keyword ref
			SquareOut( out z);		//must use keyword ref

			/* display values of y and z after they are modified by 
				method SquareRef and SquareOut, respectiveliy */
			Console.WriteLine("Value of y  after SquareRef: {0}" ,y );
			Console.WriteLine("Value of z after SquareOut: {0}\n" ,z );

			//pass y and z by value 
			Square(y);
			Square(z);

			/* display values of y and z after they are passed to method Square 
			  to demonstrate arguments passed by value are not modified */
			Console.WriteLine("Value of y after Square: {0}" ,y );
			Console.WriteLine("Value of z after Square: {0}" ,z );
	}//end main
		//uses reference parameter x to modify caller's variable
		static void SquareRef( ref int x)
		{
			x = x *x; //squares value of caller's variable
		}//end method SquareRef

		/*uses output parameter x to assign a value 
		   to an uninitialized variable */
		static void SquareOut( out int x)
		{
			x = 6; 		//assigns a value to caller's variable
			x = x *x; 	//sequares value of caller's variable
		}//end method SquareOut 

		/*parameter x receives a copy of the value passed as an argument,
			so this method cannot modify the caller's variable */
		static void Square(  int x)
		{
			x = x *x; 	
		}//end method Square
	
	}//end class ReferenceAndOutputParameters
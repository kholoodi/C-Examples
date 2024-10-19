
// See https://aka.ms/new-console-template for more information

//Read three floating-point values and determine maximum value 
using System;
public class MaximumFinder{
	//obtain three floating-point values and determine maximum value 
	public static void Main( string[] args)
	{
		//prompt for and inout three floating-point values 
		Console.WriteLine("Enter three floating-point values, \n" 
						 + " pressing 'Enter' after each on:");
		double number1 = Convert.ToDouble(Console.ReadLine());
		double number2 = Convert.ToDouble(Console.ReadLine());
		double number3 = Convert.ToDouble(Console.ReadLine());
		
		//determine the maximum value 
		double result  = Maximum(number1, number2, number3);
		//display maximum value 
		Console.WriteLine("Maximum is:" + result);
	}//end main
	//returns the maximum of its three double parameters 
	public static double Maximum(double x, double y, double z)
	{
		double maximumValue = x; 	//assume x is maximumValue 
		//determine whether y is grater than maximumValue
		if (y > maximumValue)
			maximumValue = y;
		//determine whether z is grater than maximumValue
		if (z > maximumValue)
			maximumValue = z;
		return maximumValue;

	}//end Maximum method
}//end class
 





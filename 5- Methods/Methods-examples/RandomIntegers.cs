//Shifted and scaled random integers  
using System;
public class RandomIntegers{
	public static void Main( string[] args)
	{
		Random randomNumbers = new Random(); //random -number genrator 
		int face; //stores each random integer genrated 
		//loop 20 times
		for(int i = 1; i <= 20 ; i++)
		{
			face = randomNumbers.Next(1 ,7); //pick random integer from 1 to 6
			Console.Write("{0}  ", face ); 	//display generated value 
			// if i is divisible by 5, start a new line of output 
			if ( i % 5 == 0)
			Console.WriteLine();
		}//end for

	}//end main
	}//end class
//Roll a six-sided die 6000 times  
using System;
public class RllDie{
	public static void Main( string[] args)
	{
		Random randomNumbers = new Random(); //random -number genrator 
		int frequencey1 = 0; 		//count of 1s rolled  
		int frequencey2 = 0; 		//count of 2s rolled
		int frequencey3 = 0; 		//count of 3s rolled
		int frequencey4 = 0; 		//count of 4s rolled
		int frequencey5 = 0; 		//count of 5s rolled
		int frequencey6 = 0; 		//count of 6s rolled
		int face; //stores each random integer generated

		//summarize results of 6000 rolls a die 
		for(int roll = 1; roll <= 6000 ; roll++)
		{
			face = randomNumbers.Next(1 ,7); //number from 1 to 6
			//determine roll value 1-6 and increment appropriate counter 
			switch(face)
			{
				case 1:
					++frequencey1;			//increment the 1s counter 
					break;
				case 2:
					++frequencey2; 			//increment the 2s counter 
					break;
				case 3:
					++frequencey3; 		//increment the 3s counter 
					break;
				case 4:
					++frequencey4; 		//increment the 4s counter 
					break;
				case 5:
					++frequencey5; 		//increment the 5s counter 
					break;
				case 6:
					++frequencey6; 		//increment the 6s counter 
					break;
			}//end siwitch
		}//end for
		Console.WriteLine("Face\tFrequency"); 	//output header
		Console.WriteLine("1\t{0}\n2\t{1}\n3\t{2}\n4\t{3}\n5\t{4}\n6\t{5}",
				frequencey1,frequencey2,frequencey3,frequencey4,frequencey5,frequencey6);

	}//end main
	}//end class
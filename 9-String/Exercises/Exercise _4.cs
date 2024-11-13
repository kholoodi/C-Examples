using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Concat() method 
    public static void Main(string[] args) {
      	
		string string1 = "Happy";		  
		string string2 = "Brithday";		
		string output = String.Concat(string1, string2);						
		Console.WriteLine(output);
    }//end Main
  }
}
/*
Output:

HappyBrithday
*/

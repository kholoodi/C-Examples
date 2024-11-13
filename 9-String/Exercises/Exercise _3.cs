using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//CopyTo() Method
    public static void Main(string[] args) {
      	string string1, output = " ";
		char[] chareclerArray ;
		string1 = "hello there";
		chareclerArray = new char[5];
		output += "The string reversed is:";
		
		for(int i = string1.Length -1 ; i>=0; i--)
			output += string1[i];
			
		string1.CopyTo(0,chareclerArray,0,5);
		output += "\n The character array is:";
			
		for (int i=0; i< chareclerArray.Length; i++)
			output += chareclerArray[i];
		
		Console.WriteLine(output);

    }//end Main
  }
}
/*
Output:

 The string reversed is:ereht olleh
 The character array is:hello
*/

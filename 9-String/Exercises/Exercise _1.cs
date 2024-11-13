using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	//Some string methods 
	class Exercise {
    public static void Main(string[] args) {
      string string1 = "Cheers!";
    	string string2 ="GOOD BYE";
    	string string3 ="   Good morning!   ";
    	Console.WriteLine(string1.Replace('e','E'));
    	Console.WriteLine(string1.ToUpper());
    	Console.WriteLine(string2.ToLower());
    	Console.WriteLine(string3.Trim());
    }//end Main
  }
}
/*
Output:

ChEErs!
CHEERS!
good bye
Good morning!

*/

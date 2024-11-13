using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Locating Characters and Substring in String 
    public static void Main(string[] args) {
		string letters = "abcdefghijklmabcdefghijklm";
		string output ="";
		char[] searchLetters = {'c' ,'a', '$'};
		Console.WriteLine( letters.IndexOf('c'));
		Console.WriteLine( letters.IndexOf('a',1));
		Console.WriteLine( letters.IndexOf('$',3,5));
		Console.WriteLine( letters.LastIndexOf('c'));
		Console.WriteLine( letters.LastIndexOf('a',25));
		Console.WriteLine( letters.LastIndexOf('$',15,5));
		Console.WriteLine( letters.IndexOf("def"));
		Console.WriteLine( letters.IndexOfAny(searchLetters));
		Console.WriteLine( letters.IndexOfAny(searchLetters, 7));
		Console.WriteLine( letters.IndexOfAny(searchLetters, 20,5));

    }//end Main
  }
}
/*
Output:

2
13
-1
15
13
-1
3
0
13
-1
*/

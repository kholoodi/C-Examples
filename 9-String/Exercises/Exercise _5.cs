using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Equals() and CompareTo() Methods 
    public static void Main(string[] args) {
      	
		string string1 = "hello";
		string string2 = "good bye";
		string string3 = "Happy Brithday";
		string string4 = "happy brithday";
			
		if (string1 == "hello")
			Console.WriteLine("string1 equals hello\n");
		else
			Console.WriteLine("string1 does not equals hello\n");
		
		if (String.Equals(string3 , string4))
			Console.WriteLine("string3 equals string4\n");
		else 
			Console.WriteLine("string3 doesn't equals string4\n");

		//A CompareTo method 
		Console.WriteLine(string1.CompareTo(string2));
		Console.WriteLine(string2.CompareTo(string1));
		Console.WriteLine(string3.CompareTo(string4));
		Console.WriteLine(string4.CompareTo(string3));
    }//end Main
  }
}
/*
Output:

string1 equals hello

string3 doesn't equals string4

1
-1
1
-1
*/

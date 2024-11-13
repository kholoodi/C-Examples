using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	//String constructor 
	class Exercise {
    public static void Main(string[] args) {
      	string output;
		string originalString, string1,string2, string3, string4;
		char[] chareclerArray ={'b','i','r','t','h',' ','d','a','y'};
		//string initalization
		originalString = "Welcome to C# Programming";
		string1 = originalString;
		string2 = new string(chareclerArray);
		string3 = new string(chareclerArray , 6 , 3);
		string4 = new string ('C', 5);
		output = "string1 =" + "\"" +string1 +"\"\n" +
			"string2 =" + "\"" +string2 +"\"\n" +
			"string3 =" + "\"" +string3 +"\"\n" +
			"string4 =" + "\"" +string4 +"\"\n";
		Console.WriteLine(output);
    }//end Main
  }
}
/*
Output:

string1 ="Welcome to C# Programming"
string2 ="birth day"
string3 ="day"
string4 ="CCCCC"
*/

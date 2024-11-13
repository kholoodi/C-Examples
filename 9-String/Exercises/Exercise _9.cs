using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Class StringBuilder -Append() Method
    public static void Main(string[] args) {
		char[] characterArray  = {'a','b', 'c','d'};
      	int integerValue = 7;
      	StringBuilder buffer= new StringBuilder();
    	buffer.Append("hello ");
    	buffer.Append("good bye ");
    	buffer.Append(characterArray);
    	buffer.Append(" ");
    	buffer.Append(true);
    	buffer.Append(" ");
    	buffer.Append(integerValue);
    	Console.WriteLine(buffer.ToString());
    }//end Main
  }
}
/*
Output:

hello good bye abcd True 7
*/

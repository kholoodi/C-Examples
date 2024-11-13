using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Class StringBuilder -Insert() Method
    public static void Main(string[] args) {
		char[] characterArray  = {'a','b', 'c','d'};
		int integerValue = 7;
		StringBuilder buffer= new StringBuilder();
		buffer.Insert(0,integerValue);
		buffer.Append(" ");
		buffer.Insert(2,characterArray);
		buffer.Insert(0,"bye");
		Console.WriteLine(buffer.ToString());

    }//end Main
  }
}
/*
Output:

bye7 abcd
*/

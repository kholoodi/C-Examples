using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Class StringBuilder 
    public static void Main(string[] args) {
		StringBuilder buffer1, buffer2, buffer3;
		buffer1 = new StringBuilder();
		buffer2 = new StringBuilder(10);
		buffer3 = new StringBuilder("hello");

		Console.WriteLine(buffer1.ToString());
		Console.WriteLine(buffer2.ToString());
		Console.WriteLine(buffer3.ToString()); 
    }//end Main
  }
}
/*
Output:



hello
*/

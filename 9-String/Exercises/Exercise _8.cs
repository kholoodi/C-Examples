using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //To work with string must using "System.Text"
namespace StringExamples
{
	class Exercise {
		//Class StringBuilder -Capacity property
    public static void Main(string[] args) {
		StringBuilder buffer= new StringBuilder("Hello, how are you?");
    	Console.WriteLine(buffer.ToString());
    	Console.WriteLine(buffer.Length);
    	Console.WriteLine(buffer.Capacity);
    	buffer.EnsureCapacity(75);
    	buffer.Length =10;
    	Console.WriteLine(buffer.Length);
    	Console.WriteLine(buffer.Capacity);

    }//end Main
  }
}
/*
Hello, how are you?
19
19
10
75
*/

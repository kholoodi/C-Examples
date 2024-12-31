//-----------Example 3 -------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
              public static void Main(string[] args)
		{
		  const int X = 10;
                string str = "Hello, world";
                int num = 1;
                float num0 = 0;
                bool x = true;
                char a = 'a';
                Console.Write("{0}\n {1} \t {2}\n {3}  {4}\n {5}", str, num, num0, x, a ,X);
  	       }
	}
}

/**
Output:

Hello, world
 1 	 0
 True  a
 10
**/
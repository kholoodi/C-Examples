using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
  class A {
		public void disp(){
		  Console.WriteLine("disp() method of class A");
		}
	}
	interface fgh { void mno();}
	interface ljk { void pqr();}
	
	class Z:A,fgh,ljk {
		public void mno()
	  		{ Console.WriteLine("mno() method is overridden. ");}
		public void pqr()
	  		{ Console.WriteLine("oqr() method is overridden. ");}
	}
	class program {
		public static void Main(string[] args) {
			Z obj = new Z();
			obj.disp();
			obj.mno();
	    		obj.pqr();
	    		Console.ReadLine();
	  	} 
	}
}
/*
Output:

disp() method of class A
mno() method is overridden. 
oqr() method is overridden
*/
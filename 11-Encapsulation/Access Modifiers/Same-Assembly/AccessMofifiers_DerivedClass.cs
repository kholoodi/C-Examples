using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace App1
{
		public class AccessModifiers{
		  private string privateAccess =  "A private member";
		  public string publicAccess="A public member";
		  protected string protectedAccess = "A protected member";
		  internal string internalAccess ="An internal member";
		  }
		public class DerivedClass:AccessModifiers{
		  //access in the Derived class
		  public void display(){
			//The Derived Class Can not access to the private members 
		    //Console.WriteLine(privateAccess); //Error
		    Console.WriteLine(publicAccess);
		    Console.WriteLine(protectedAccess);
		    Console.WriteLine(internalAccess);
		  }

		}
		public class Program
	{
		public static void Main(string[] args)
		{
			DerivedClass obj = new DerivedClass();
            obj.display();
		}
		
	}
		
}

/**
Output:

A public member
A protected member
An internal member
**/
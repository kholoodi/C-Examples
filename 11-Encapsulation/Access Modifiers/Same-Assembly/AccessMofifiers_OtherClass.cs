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
		public class OtherClass{
		  //access in the Other class
		  public void display(){
		    AccessModifiers testobj = new AccessModifiers();
		    Console.WriteLine(testobj.publicAccess);
		    Console.WriteLine(testobj.internalAccess);
		    //Errors the other classes in the same assembly can not access to private and protected members 
		  //Console.WriteLine(testobj.privateAccess); //Error
		   //Console.WriteLine(testobj.protectedAccess); //Error

		  }

		}
		public class Program
	{
		public static void Main(string[] args)
		{
			OtherClass obj = new OtherClass();
            obj.display();
		}
		
	}
		
}

/**
Output:

A public member
An internal member
**/
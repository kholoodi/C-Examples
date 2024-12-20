using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//The examples for access modifiers 
namespace App1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			AccessModifiers obj = new AccessModifiers();
            obj.display();
		}
		
		public class AccessModifiers{
		  private string privateAccess =  "A private member";
		  public string publicAccess="A public member";
		  protected string protectedAccess = "A protected member";
		  internal string internalAccess ="An internal member";
	  
		  //access in the same class 
		  public void display(){
		    Console.WriteLine(privateAccess);
		    Console.WriteLine(publicAccess);
		    Console.WriteLine(protectedAccess);
		    Console.WriteLine(internalAccess);
		  }

		}
		
	}
}
/**
Output:

A private member
A public member
A protected member
An internal member

**/
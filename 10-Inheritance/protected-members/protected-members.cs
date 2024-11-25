using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Protected Members
  class Person {
    protected string name;
    protected void Print(){
       Console.WriteLine("Base Class");
    }
  }
  class Student:Person {
   public Student (string n){
     //Access to protected attribute
     name = n;
   }
    public void PrintnName(){
      //Access  to protected method
      Print();
      Console.WriteLine("Name is:" + name);
    }
  }
  	public class Program
	{
		public static void Main(string[] args)
		{
			Student st1 = new Student("Asma");
            st1.PrintnName();
		}
	}
}
/*
Output:

Base Class
Name is:Asma
*/
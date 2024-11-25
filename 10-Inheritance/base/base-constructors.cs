using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Using base members 
  class Person {
    public string name;
    public Person (string n){
        Console.WriteLine("Base Constructor!");
        name = n;
    }
  }
  class Student:Person {
    public int degree;
    //using the "base" keyword assignment the n value to "name" attribute in the base class
    public Student (int d, string n):base(n) {
        Console.WriteLine("Derived Constructor!");
        degree = d;
    }
    public void Print(){
        //Access to base attribute "name" in the base class  via derived class
        Console.WriteLine("Name is: {0}\nDegree is {1}", name, degree);
    }
  }
  	public class Program
	{
		public static void Main(string[] args)
		{
			Student st1 = new Student(20, "Halh");
            st1.Print();
	}
}
/*
Output:

Base Constructor!
Derived Constructor!
Name is: Halh
Degree is 20
*/
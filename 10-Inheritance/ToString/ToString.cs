using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Using ToString
  class Person {
    public string name;
    public Person (string n){
        name = n;
    }
    public override string ToString(){
	    return string.Format("name is: "+ name);
	}
  }
  class Student:Person {
    public int degree;
    public Student (int d, string n):base(n) {
        degree = d;
    }
    public override string ToString(){
	    return string.Format(base.ToString() + "\nDegree is: " + degree);
	}
    
  }
  	public class Program
	{
		public static void Main(string[] args)
		{
			Student st1 = new Student(20, "Hala");
            Console.WriteLine(st1.ToString());
 		}
	}
}
/*
Output:

name is: Hala
Degree is: 20
*/
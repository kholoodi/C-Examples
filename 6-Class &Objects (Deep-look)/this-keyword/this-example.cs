using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Student
{
  public class Students{
	int age;
	string name;
	//using "this" keyword to refer instance variables	
	public Students(){ 
		this.age = 0;
		this.name ="unknown";
	}
	//OR using short formula to "this"
	//public Students():this (0, "unknown"){ }
	public Students(int a, string n){
	age = a;
	name = n;
	Console.WriteLine("Constructor with parameters");
	Console.WriteLine(ToString());
	}
	public override string ToString(){
	return string.Format("[Students Age ={0}, Name={1}]", age, name);
	}
}//end class Students
  class StudentsTest{
  	public static void Main(string[] args){
  		Students st1 =new Students();
  		Students st2 = new Students(18, "Tagreed");
  		Console.ReadLine();
  	}	
}

}
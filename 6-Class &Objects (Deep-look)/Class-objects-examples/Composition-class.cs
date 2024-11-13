using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// An Example of composition to reusing classes as components in other classes
namespace App
{
  public class Person {
  	int age {get; set;}
  	string name;
  	public Person(int a , string n){
  		Age = a;
  		name = n;
  	}
  	public int Age{
  		get {return age;}
  		set { age = (value > 0? value:0);}
  	}
  	public override string ToString(){
  		return string.Format("Person Name = {0}, Age ={1}", name, age);
  		}
  }//end Person class

	public class Employee {
  	Person info; 
  	double salary;
  	//reuse Person as a component  in Employee class 
  	public Employee(Person p, double s){
  	    salary = s;
  	    info =p;
  	  }
  	public override string ToString(){
  	    return string.Format("{0}\nSalary = {1}", info, salary);
  	  }
  }//Employee
  public class EmployeeTest{
  	public static void Main(string[] args){
  		Person p = new Person(30, "nahla");
  		Employee em = new Employee(p , 10.000);
  		Console.WriteLine(em);
  		Console.ReadLine();
  	}
  }
}
/*
Output:

Person Name = nahla, Age =30
Salary = 10
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/**-The Student class has name and egree as private attributes. Student also contains constructor to initalize the attributes. And it should proived the Name and Degree as properties to the private attributes. The Degree property set method should test that (course degree is grater than or equal 0 ans less than or equal 100).
-The Student  also has the method name "Grade" which print  "Faill" if the degree less than 60 and print  "Pass" if the degree is more than or equal 60.
**/
namespace App
{
  public class Student{
    //private class attributes 
    private string name;
    private double degree;
    
    //constructor
    public Student (string n, double d){
      name = n;
      degree = d;
    }
    //Properties
    public string Name {get; set;}
    public double Degree {
      get { return degree;}
      set { degree = value >= 0 && value <= 100 ? value : 0;}
    }
    //A public method
    public void Grade (){
      Console.WriteLine("The student {0} is: {1}", name, degree < 60 ? "Faill" : "Pass");
    }
  }
	public class Program
	{
		public static void Main(string[] args)
		{
		  //Access to private members by constructor 
			Student st = new Student("Maha", 85);
			//Access to private members via method 
			st.Grade();
			//Access to private members via properties 
			st.Degree = 59;
			st.Grade();
		}
	}
}
/**
Output:

The student Maha is: Pass
The student Maha is: Faill
**/
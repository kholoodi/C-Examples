using System;
using App;
public class GradeBook {
    public string courseName {get; set;}

	//Constructor initializes auto-implemented property 
   	//courseName with string supplied as argument 
   	 public GradeBook(string name )
	{	courseName = name; 	}
	public void DisplayMessage()
   	 {
	Console.WriteLine("Welcome to grade book for \n {0}!", courseName); 
     }
}
using System;
using App;
public class GradeBook {
    //auto-impemented property courseName implicitly creates 
        //an instance variable for this GradBook's name 
        public string courseName {get; set;}
	
    //display a wlecom message to the GradBook user 
    public void DisplayMessage()
    {
        //use auto-impemented property courseName to get the name of the course that is GradBook repersents 
        Console.WriteLine("Welcome to grade book for \n {0}!", courseName); //diasplay auto-impemented property courseName 
    }
}
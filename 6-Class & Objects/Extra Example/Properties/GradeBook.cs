using System;
using App;
public class GradeBook {
    private string courseName; 	//course name for this GradeBook
	//property to get and set the course name 
	public string CoursName
	{
	get { return courseName; 	}
	set { courseName = value; 	}
	} 
	//display a wlecom message to the GradBook user 
	public void DisplayMessage(){
        //use property courseName to get the name of the course that is GradBook repersents 
        Console.WriteLine("Welcome to grade book for \n {0}!", courseName); //diasplay property courseName 

    }
}
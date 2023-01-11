using System;
namespace App
{
    class School
    {
        public static void Main(string[] args)
        {
           //Calling the public non-static method
	   //First, must create an object from the class 
	   //The object named student1 
            Students student1 = new Students(); 
            //Then calling the method by the object name 
            student1.WelcomeMessage("Marum");

            //The second object named student2
            Students student2 = new Students(); 
            student2.WelcomeMessage("Noor");

        }
    }

}


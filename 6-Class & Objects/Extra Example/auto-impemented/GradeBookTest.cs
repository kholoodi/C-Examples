using System;
namespace App
{
    class GradeBookTest
    {
        //Main method begins program exexcution 
        public static void Main(string[] args)
        {
            //create a GradeBook object and assign it to myGradeBook
            GradeBook myGradeBook = new GradeBook();
            //display initial value of courseName 
            Console.WriteLine("Initial course name is: '{0}'\n",myGradeBook.courseName ); 
            //prompt for and read course name 
            Console.WriteLine("Please enter the course name:");
            myGradeBook.courseName = Console.ReadLine(); //set CourseName 
            //display welcome message after specifying course name 
            myGradeBook.DisplayMessage();


        }
    }

}


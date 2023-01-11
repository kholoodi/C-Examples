using System;
namespace App
{
    class GradeBookTest 
    {
        //Main method begins program exexcution 
        public static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();
            Console.WriteLine("Initial course name is: '{0}'\n",myGradeBook.CoursName ); 
            //prompt for and read course name 
            Console.WriteLine("Please enter the course name:");
            myGradeBook.CoursName = Console.ReadLine(); //set CourseName 
            //display welcome message after specifying course name 
            myGradeBook.DisplayMessage();


        }
    }

}


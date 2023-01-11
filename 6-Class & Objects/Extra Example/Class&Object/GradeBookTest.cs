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
            //prompt for and input course name 
            Console.WriteLine("place enter the course name:" );
            string nameOfCourse = Console.ReadLine(); 
            Console.WriteLine();	//output a blank line 
            //call myGradeBook’s DisplayMessage method 
            //and pass nameOfCourse as argument 
            myGradeBook.DisplayMessage(nameOfCourse);

        }
    }

}


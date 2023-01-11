using System;
namespace App
{
    class GradeBookTest
    {
        //Main method begins program exexcution 
        public static void Main(string[] args)
        {
            //create a GradeBook object and assign it to myGradeBook invokes constructor 
            GradeBook GradeBook1 = new GradeBook("CS101 Introduction to C# Programming ");
            GradeBook GradeBook2 = new GradeBook("CS102 Introduction to Data structures in C#");
            //display initial value of courseName for each GreadeBook 
            Console.WriteLine("GradeBook1 course name is: '{0}'\n",GradeBook1.courseName ); 
            Console.WriteLine("GradeBook2 course name is: '{0}'\n",GradeBook2.courseName ); 



        }
    }

}


//The appliction for storing student grades in a rectangular Array in class "GradeBook"
/*The verision of class GradeBook presented here uses  a rectangular Array grades
to sorte  the grades of a number of students*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook2D;
namespace GradeBook2D
{
    public class GradeBook {
        private int [, ]  grades;     //rectangular array of student grades 
        //auto-implemented property CourseName
        public string CourseName{ get; set;}

        //two-parameter constructor initilizes
        //Auto-implemented property courseName and grades array
        public GradeBook (string name, int[,] gradesArray){
            CourseName = name;      
            grades = gradesArray;   //initilize grades array 
        }// end two-parameter GradeBook constructor

        //Display a welcome message to the GradeBook 
        public void DisplayMessage(){
            //Auto-implemented property CurouseName gets the name of course
            Console.WriteLine ("Welcom to the Grad Book for \n{0}!\n", CourseName);
        }
        //preform version operations on the data
        public void ProcessGrade(){
            //output grade array
            OutputGrades();
             //call method GetMinmum and GetMaximum 
            Console.WriteLine("\n {0} {1}\n{2} {3}\n",
                                "Lowest grade in the grade book is:", GetMinmum(),
                                "Highest grade in the grade book is:", GetMaximum());
            //call OutputBarChart to dispaly grade distributtion chart
            OutputBarChart();
        }//end ProcessGrade method 
        //Find the minimum grade 
        public int GetMinmum(){
            int lowGrade = grades[0,0]; //assume first element of  grades is smallest
            //loop through elements of rectangular grades array 
            foreach (int grade in grades){
                //If grade lower than lowGrade, assign it to lowGrade
                if(grade < lowGrade)
                    lowGrade = grade;   //new lowest grade
            }//end for 
            return lowGrade;    //retrun lowest grade
        }//end method GetMinmum

        //Find the maximum grade 
        public int GetMaximum(){
            int highGrade = grades[0,0];   //assume first element of  grades is largest
            //loop through grades array 
            foreach (int grade in grades){
                //If grade lower than highGrade, assign it to highGrade
                if(grade > highGrade)
                    highGrade = grade;   //new highest grade
            }//end for 
            return highGrade;    //retrun lowest grade
        }//end method GetMaximum

        //determine average grade for particular student  
        public double GetAverage(int student ){
            //get the number of grades per student 
            int amount = grades.GetLength(1);
            int total = 0;
            //sum grades for one student 
            for(int exam = 0; exam < amount; exam++)
                total += grades[student, exam];
            //return average of grades
            return (double) total/amount;
        }//end method GetAverage 
        //output bar chart displaying grade distribution 
        public void OutputBarChart(){
            Console.WriteLine("Overall grade distributtion:");
            //sortes frequency of grades in each range of 10 grades
            int[] frequency = new int[11];
            //for each grade, increment the appropiate frequency
            foreach (int grade in grades)
              ++frequency[ grade /10];
            //for each grade frequency, display bar in chat
            for(int count = 0; count < frequency.Length; count++){
                //output bar label ("00-09",....,"90-99", "100: ")
                if(count == 10)
                Console.Write("100 :");
                else
                Console.Write("{0:D2}-{1:D2}:", count * 10, count * 10 + 9);
                //display bar of asterisks 
                for (int stars = 0; stars < frequency[count]; stars++)
                Console.Write("*");
                Console.WriteLine();    //start a new line of output 
            }// end outer for 
        }//end method OutputBarChart
        //output the contents of the grades array 
        public void OutputGrades(){
            Console.WriteLine("The grades are:\n");
            Console.Write("      "); //align column heads 
            //Create a column heading for each of the test
            for (int test = 0; test < grades.GetLength(1); test++)
                Console.Write("Test {0}:   ",test+1);
            Console.WriteLine("Average"); //student average column heading 
            //Create rows/columns of the text respresenting aarray grades 
            for(int student = 0; student < grades.GetLength(0); student++){
                Console.Write("Student {0,2}", student +1);
                for(int grade = 0; grade < grades.GetLength(1); grade++)
                     Console.Write("{0,8}", grades[student, grade]);
                //call method GetAverage to calculate student's average grade
                //pass row number as the argument to GetAverage
                Console.WriteLine ("{0,9:F}", GetAverage(student)); 
            }//end outer for 
        }//end method OutputGrades
    }//end Class GreadeBook
}
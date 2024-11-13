//The appliction for storing student grades in an array in class "GradeBook"
/*The verision of class GradeBook presented here uses an array of intgers 
to sorte the grades of several students on a singel exam */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook1D;
namespace GradeBook1D
{
    public class GradeBook {
        private int []  grades;     //An array of student grades
        //auto-implemented property CourseName
        public string CourseName{ get; set;}

        //two-parameter constructor initilizes
        //Auto-implemented property courseName and grades array
        public GradeBook (string name, int[] gradesArray){
            CourseName = name;  
            grades = gradesArray;   //initilize grades array 
        }// end two-parameter GradeBook constructor
        //Display a welcome message to the GradeBook 
        public void DisplayMessage(){
            //Auto-implemented property CurouseName gets the name of course
            Console.WriteLine ("Welcom to the Grad Book for \n{0}", CourseName);
        }
        //preform version operations on the data
        public void ProcessGrade(){
            //output grade array
            OutputGrades();
            //call method GetAvaerge to clculate the averagea
            Console.WriteLine("\nClass average is {0:F}", GetAverage());
            //call method GetMinmum and GetMaximum 
            Console.WriteLine("Lowest grade is {0}\nHighest grade is {1}\n",GetMinmum(), GetMaximum() );
            //call OutputBarChart to dispaly grade distributtion chart
            OutputBarChart();
        }//end ProcessGrade method 
        //Find the minimum grade 
        public int GetMinmum(){
            int lowGrade = grades[0]; //assume grades[0] is smallest
            //loop through grades array 
            foreach (int grade in grades){
                //If grade lower than lowGrade, assign it to lowGrade
                if(grade < lowGrade)
                    lowGrade = grade;   //new lowest grade
            }//end for 
            return lowGrade;    //retrun lowest grade
        }//end method GetMinmum

            //Find the maximum grade 
        public int GetMaximum(){
            int highGrade = grades[0];   //assume grades[0] is largest
            //loop through grades array 
            foreach (int grade in grades){
                //If grade lower than highGrade, assign it to highGrade
                if(grade > highGrade)
                    highGrade = grade;   //new highest grade
            }//end for 
            return highGrade;    //retrun lowest grade
        }//end method GetMaximum

        //determine average grade for test 
        public double GetAverage(){
            int total = 0;
            //sum grades for one student 
            foreach (int grade in grades)
            total += grade;
            //return average of grades
            return (double) total/grades.Length;
        }//end method GetAverage 
        //output bar chart displaying grade distribution 
        public void OutputBarChart(){
            Console.WriteLine("Grade distribution:");
            //sortes frequency of grades in each range of 10 grades
            int[] frequency = new int[11];
            //for each grade, increment the appropiate frequency
            foreach (int grade in grades)
              ++frequency[ grade /10];
            //for each grade frequency, display bar in chat
            for(int count =0; count < frequency.Length; count++){
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
            //output each student's grade 
            for (int student = 0; student < grades.Length; student++)
                Console.WriteLine("Student {0,2}: {1,3}",student+1, grades[student]);
        }//end method OutputGrades
    }//end Class GreadeBook
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook1D
{
    /* Class GradeBookTest demonstrates class GradeBook*/
	public class GradeBookTest
	{
		public static void Main(string[] args)
		{
            //one-dimensional array of student grades
            int[] gradesArray ={87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            GradeBook myGreadeBook = new GradeBook("CS101 Introduction to C# Programming!", gradesArray);
            myGreadeBook.DisplayMessage();
            myGreadeBook.ProcessGrade();
		}
	}
}
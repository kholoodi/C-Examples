using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook2D
{
    /* Class GradeBookTest demonstrates class GradeBook*/
	public class GradeBookTest
	{
		public static void Main(string[] args)
		{
            //one-dimensional array of student grades
            int[,] gradesArray = { {87, 96, 70 }, {68, 87, 90 },
                                  {94, 100, 90}, {100, 81, 82},
                                  {83, 65, 85 }, {78, 87, 65 },
                                  {85, 75, 83 }, {91, 94, 100 },
                                  {76, 72, 84 }, {87, 93, 73 } };
            GradeBook myGreadeBook = new GradeBook("CS101 Introduction to C# Programming", gradesArray);
            myGreadeBook.DisplayMessage();
            myGreadeBook.ProcessGrade();
		}
	}
}
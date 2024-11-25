using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
  //Using base members 
  class Info {
    public char grade;
    public Info (char g){
        grade = g;
    }
    public virtual void Display(){
      Console.WriteLine("Grade = {0}", grade);
    }
  }
  class infoDtails:Info {
    string course;
    int degree;
    public infoDtails (string c, int d, char g):base(g) {
        course = c;
        degree = d;
    }
    public override void Display(){
      Console.WriteLine("Course is :" +course);
      Console.WriteLine("Degre is :" +degree);
      base.Display();
    }
  }
  public class Program
	{
    public static void Main(string[] args) {
      Info info1 =  new Info('B');
			infoDtails info2 = new infoDtails("C#",90,'A');
      info1.Display();
      info2.Display();
		}
	}
}
/*
Output:

Grade = B
Course is :C#
Degre is :90
Grade = A
*/
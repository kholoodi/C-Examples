
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//Overloaded Constructor example 
namespace Student
{
    public class Students{
        int age;
        string name;
        public Students(){
            age = 0;
            name = "unknown";
            Console.WriteLine("Parameter less Constructor");
            Console.WriteLine(ToString());
        }
        public Students(int a, string n){
            age = a;
            name = n;
            Console.WriteLine("Constructor with parameters");
            Console.WriteLine(ToString());
        }
        public override string ToString(){
            return string.Format("[Students Age ={0}, Name={1}]", age, name);
        }
    }//end class Students
    class StudentsTest{
        public static void Main(string[] args){
            Students st1 =new Students();
            Students st2 = new Students(18, "Tagreed");
            Console.ReadLine();
        }	
    }
}
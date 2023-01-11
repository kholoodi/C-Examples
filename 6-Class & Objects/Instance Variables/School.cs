using System;
namespace App
{
    class School
    {
        public static void Main(string[] args)
        {
           
           Students student1 = new Students(); 
            //Assigning a value to the name attribute in the class student1
            student1.name = "Mona";
            student1.WelcomeMessage(student1.name);
        }
    }
}


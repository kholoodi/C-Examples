using System;
namespace App
{
    class School
    {
        public static void Main(string[] args)
        {
            Students student1 = new Students(); 
            student1.name = "Mona";
            //Access via property 
            student1.Id = 1;   
            student1.WelcomeMessage(student1.name ,student1.Id);
        }
    }
}


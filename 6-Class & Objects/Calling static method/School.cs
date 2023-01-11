using System;
namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type your name: ");
            string name = Console.ReadLine();
            //calling the public static method from the class 
            Students.WelcomeMessage(name);
        }
    }

}


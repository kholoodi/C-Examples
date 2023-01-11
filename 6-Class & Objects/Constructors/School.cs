
namespace App
{
    class School
    {
        public static void Main(string[] args)
        {
            //Here the constructor of default values will calling  
            Students student1 = new Students();  
            
            //Here the constructor of both values will calling
            Students student2 = new Students("Maram", 1);
            
            //Here the constructor of name value will calling
            Students student3 = new Students ("Amal");
    
            Console.WriteLine( "The student name is {0}, and the id number is {1}",student1.name, student1.ID);
            Console.WriteLine("The student name is {0}, and the id number is {1}",student2.name,student2.ID);
            Console.WriteLine("The student name is {0}, and the id number is {1}",student3.name, student3.ID);
        }
    }

}


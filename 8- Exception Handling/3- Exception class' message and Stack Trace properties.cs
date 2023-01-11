//Exception class' message and Stack Trace properties 
string s = null;

        Console.WriteLine("Before Printing Lower case string");
        Console.WriteLine(s.ToLower());
        Console.WriteLine("After Printing Lower case string...");

//in the output we see the Error message withe the class name to solve problem 
/*-----Output---------
Before Printing Lower case string
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
*/
// Since we did not catch the NullReferenceException, our program got terminated premateurly with runtime (CLR) reporting two things 
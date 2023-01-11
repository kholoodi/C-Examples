string s = "Faraz";
try 
{
        Console.WriteLine("In try block before calling s.ToLower() "); 
        Console.WriteLine( s.ToLower());
        Console.WriteLine("In try block after calling s.ToLower()"); 
}
catch(NullReferenceException e)
{
        Console.WriteLine("\nIn catch block...");
        Console.WriteLine("NullReferenceException caught");
}
finally
{
        Console.WriteLine("\nIn finally block...");
}
/*-------Output-----
In try block before calling s.ToLower() 
faraz
In try block after calling s.ToLower()

In finally block...
*/
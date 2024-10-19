string s = null; 
try 
{
        Console.WriteLine("Entering try block..."); 
        Console.WriteLine("Leaving the try block..");
}
//catch for NullReferenceExeptio
catch(NullReferenceException e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine(e.Message);
}
finally
{
        Console.WriteLine("In finally block...");
}
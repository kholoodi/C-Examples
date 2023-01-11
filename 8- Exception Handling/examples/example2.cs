
int [] i = new int[3];
try 
{
        Console.WriteLine("In try block...");
        i[0] = 0; 
        i[1] = 4/i[0]; 
        Console.WriteLine("The second element of array is: "+ i[1]);
}
catch( Exception e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine("Exception Caught");
        Console.WriteLine(e.Message);      
}

/*
----------Output--------
In try block...
In catch block...
Exception Caught
Attempted to divide by zero.
*/
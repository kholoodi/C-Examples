int [] i = new int[3];
try 
{
        Console.WriteLine("In try block...");
        i[0] = 0; 
        i[1] = 4/i[0]; 
        Console.WriteLine("The second element of array is: "+ i[1]);
}
catch( DivideByZeroException e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine("Exception Caught");
        Console.WriteLine(e.Message);      
}
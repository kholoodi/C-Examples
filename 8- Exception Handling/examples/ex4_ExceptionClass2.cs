string s = "Programming"; // set null value for NullReferenceException 
int [] i = new int[3]; 
try 
{
        Console.WriteLine("Entering try block...");
        Console.WriteLine("Lower cause name is: "+ s.ToLower());
        //can cause IndexOutOfRangeException by =&gt; i[6].ToString()
        Console.WriteLine("First element of array is: "+ i[6].ToString()); 
        Console.WriteLine("Leaving the try block..");
}
//catch for NullReferenceExeptio
catch(NullReferenceException e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine(e.Message);
}
//catch for IndexOutOfRangeException
catch(IndexOutOfRangeException e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine(e.Message);
}
// the catch for any other exceptions
catch(Exception e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine("Exception Caught");
        Console.WriteLine(e.Message);
}
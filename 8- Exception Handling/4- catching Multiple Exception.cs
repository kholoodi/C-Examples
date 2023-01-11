//catching Multiple Exception using multiple catch blocks 

string s = "Faraz";
int [] i = new int[3];
try 
{
        Console.WriteLine("Rntering try block...\n");
        //can cause NullReferenceExeption 
        Console.WriteLine("Lower cause name is: "+ s.ToLower());
        //can cause NullRferenceException or IndexOutOfRangeException
        Console.WriteLine("First element of array is: "+ i[0].ToString()); //try i[5].ToString()
        i[0] = 3; // set a value = 0
        i[1] = 4/i[0]; 
        Console.WriteLine("\nLeveaing the try block..");
}
catch(NullReferenceException e)
{
        Console.WriteLine("\nIn catch block...");
        Console.WriteLine("NullReferenceException caught");
}
catch(IndexOutOfRangeException e)
{
        Console.WriteLine("\nIn catch block...");
        Console.WriteLine("IndexOutOfRangeException caught");
}
catch(Exception e)
{
        Console.WriteLine("\nIn catch block...");
        Console.WriteLine("Exception Caught");
        Console.WriteLine(e.Message);
}
Console.WriteLine("After try...catch block");

/*
----------Output--------
Rntering try block...

Lower cause name is: faraz
First element of array is: 0

In catch block...
Exception Caught
Attempted to divide by zero.
After try...catch block
*/


string s = null;
try 
{
        Console.WriteLine("In try block...before calling s.Tolower()");
        Console.WriteLine(s.ToLower());
        Console.WriteLine("In try block...After calling s.Tolower()");
}
catch(NullReferenceException e)
{
        Console.WriteLine("In catch block...");
        Console.WriteLine("NullReferenceException caught");
}
Console.WriteLine("After try...catch block");

/*
----------Output--------
In try block...before calling s.Tolower()
In catch block...
NullReferenceException caught
After try...catch block

*/
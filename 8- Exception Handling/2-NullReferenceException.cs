string s = "Paraz";
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
paraz
In try block...After calling s.Tolower()
After try...catch block
*/
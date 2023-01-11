using System;
class program
{
        static double Divide (double a, double b)
{
        if (b == 0 )
                throw InvalidEnumArgumentException();
        double c = a/b;
        return c; 
}
  public static void Main(string[] args)
  {
     int X = 0;
     try
     {
        if ( X ==0 )
        throw new DivideByZeroException ("Invalid Division");
        Console.WriteLine(10/X);
     } 
     catch(DivideByZeroException e)
     {
        Console.WriteLine(e.Message);
     }  
     Console.WriteLine("LAST STATEMENT");
   
}
  
}
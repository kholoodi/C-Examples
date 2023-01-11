using System.ComponentModel;
using System;
class program
{
  public static void Main(string[] args)
  {
     try 
     {
        int x , y;
        double z;
     x = Convert.ToInt32(Console.ReadLine());
     y =  Convert.ToInt32(Console.ReadLine());
        z = x/y;
     Console.WriteLine("Z" + z);
     }
     //Input string was not in correct format 
     catch(Exception e)
     {
        Console.WriteLine(e.StackTrace);
     }
    
     Console.ReadLine();

     }    
}
  
/*---Output---
Sdf
format exception occuredo.
*/
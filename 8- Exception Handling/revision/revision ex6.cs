using System;
class MyException:Exception{
        public MyException():base("not allowed"){}
}
class TestMyException
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
        //Console.WriteLine(e.Message);
        throw new MyException();
     }
     Console.ReadLine();
     }    
}
/*---Output---
rettt
Unhandled exception. MyException: not allowed
*/
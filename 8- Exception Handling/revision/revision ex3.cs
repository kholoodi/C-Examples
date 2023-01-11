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
     catch( FormatException f)
     {
        Console.WriteLine("format exception occured \n"+ f.Message);
     }
     //attempt to devide by zero 
     catch( DivideByZeroException d)
     {
        Console.WriteLine(" division by zreo exception occcured\n"+ d.Message);
     }
     //compilation error to put it as first catch 
     catch(Exception e)
     {
        Console.WriteLine("an exception\n"+ e.Message);
     }

    Console.ReadLine();
     } 
    
}
  
/*---Output---
3
0
 division by zreo exception occcured
Attempted to divide by zero.
*/
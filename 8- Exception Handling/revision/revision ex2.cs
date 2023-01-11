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
     catch( Exception e)
     {
        Console.WriteLine("exception occcured");
     }

    Console.ReadLine();
     } 

 /*----Output---
    Ref
exception occcured
*/
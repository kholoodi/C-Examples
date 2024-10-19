

class Program
{
    public static void Main(string[] args)
    {
        int a = 0; 
        Console.WriteLine(a);
        //Calling increment method from incremented class
        incremented.increment( a); 
        Console.WriteLine(a);
    }
 
}
//Declaring incremented class
class incremented{
 public static void increment ( int x ) 
    {
        x =+1;
         Console.WriteLine(x);
    }
}


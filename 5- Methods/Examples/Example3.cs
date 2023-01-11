

class Program
{
    public static void Main(string[] args)
    {
        int a = 0; 
        Console.WriteLine(a);
        increment(ref a);
        Console.WriteLine(a);
    }
  static void increment ( ref int  x ) 
    {
        ++x;
         Console.WriteLine(x);
    }
}


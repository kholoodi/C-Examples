

class Program
{
    public static void Main(string[] args)
    {
        int a = 0; 
        Console.WriteLine(a);
        increment(out a);
        Console.WriteLine(a);
    }
  static void increment (out int x ) 
    {
        x =+1;
         Console.WriteLine(x);
    }
}


class Program
{
    public static void Main(string[] args)
    {
        int a = 0; 
        Console.WriteLine(a);
        increment(a);
        Console.WriteLine(a);
    }
  static void increment (int x ) 
    {
        ++x;
         Console.WriteLine(x);
    }
}


//------Example 1-----
class Program
{
    public static void Main(string[] args)
    {
        PrintName("Sara");
        PrintName("Nora");
        PrintName();
    }
  static void PrintName (string Name = "Unknown name") 
    {
         Console.WriteLine(Name);
    }
}

/*------outputs---------
Sara
Nora
Unknown name
----------*/
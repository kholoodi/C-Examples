

class Program
{
    public static void Main(string[] args)
    {
       
        int a = 1,  b = 2;
        double c = 2.5, d = 3;
        Add(a,b);
        Add(c,d );
        
    }
    public static void Add(int x, int y){
        Console.WriteLine("The result for addition two integer numbers is {0}", x + y );
    }
     public static void Add(double x, double y){
        Console.WriteLine("The result for addition two float numbers is {0}", x + y );
    }
 
}


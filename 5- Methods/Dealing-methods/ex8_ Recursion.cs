class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Multiplication(5, 2)) ;
        Console.WriteLine(Multiplication(3, 2)) ;
        Console.WriteLine(Multiplication(5, 3)) ; 
        Console.WriteLine(Multiplication(5, 0)) ; 
        Console.WriteLine(Multiplication(0, 3)) ; 
    }
    public static int Multiplication (int x, int y){
        if ( y == 0) //base case 
        return 0;
        //recursion step 
        else return (x +  Multiplication(x ,y-1));    
    }
}
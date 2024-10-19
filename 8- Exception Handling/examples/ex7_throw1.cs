int X = 0;
     try
     {
        if ( X ==0 )
        Console.WriteLine(10/X);
     } 
     catch(DivideByZeroException e)
     {
        Console.WriteLine(e.Message);
        throw;
     } 
//-----------Example 5 ------------
         //Variables and constants declaration statement
         const int A = 2, B = 1, C = 3;
         int  y = 0;
         // Reading the x value from user 
         Console.Write(" Please ,Enter the x value:  ");
         int x = Convert.ToInt32(Console.ReadLine());
         // Calculation the y value 
         y =  A * ( x * x) + ( B * x  - C);
         //print the output 
         Console.WriteLine("y = " + y);
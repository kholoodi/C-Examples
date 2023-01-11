
//using System.Collections;
//using System.ComponentModel;
//using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
     //Declaration of the two-dimensional array and initialize it.
int[ , ] arr = {{1, -2 , 3}, {4, 5, 6}, {17, 8, 9}, {4, 0, 6}};
//The nested loop  for printing  the 2D array elements values
for (int i = 0; i < 4; i++)
{
    for(int j= 0; j < 3 ; j++)
    {
        Console.Write( "\t"+ arr[i,j] );
    }
    Console.WriteLine();
}
        

    }


/*
        1       -2      3
        4       5       6
        17      8       9
        4       0       6
*/
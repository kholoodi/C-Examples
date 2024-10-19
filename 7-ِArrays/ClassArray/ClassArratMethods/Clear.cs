
using System.Collections;
using System.ComponentModel;
using System;

    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
        int [] arr0 = {5, 2, 3, 1 ,0};
        int[] arr1 = {2, 1,6 , 9, 8};
        int [] arr = arr0;
         int[] arrTarget = new int[4];
         // Two-dimensional array
        int[, ] arr2 = new int[, ] { { 1, 2 },{ 3, 4 },{ 5, 6 },{ 7, 8 } };
        
        
         Array.Clear(arr0);
         foreach(int value in arr0)
         Console.Write(  value + "\t");
         Console.WriteLine();

        Array.Clear(arr1, 2,1);
        foreach(int value in arr1)
        Console.Write(  value + "\t");

            
          


        }

    }

/*
0       0       0       0       0
2       1       0       9       8
*/

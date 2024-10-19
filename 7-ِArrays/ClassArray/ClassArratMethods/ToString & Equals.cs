
using System.Collections;
using System.ComponentModel;
using System;
//using System.Collections;
//using System.ComponentModel;
//using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
        int [] arr0 = {5, 2, 3, 1};
        int[] arr1 = {1, 2, 3, 4, 5};
        int [] arr = arr0;
         int[] arrTarget = new int[4];
         // Two-dimensional array
        int[, ] arr2 = new int[, ] { { 1, 2 },{ 3, 4 },{ 5, 6 },{ 7, 8 } };
        
          Console.WriteLine(arr1.ToString());
          Console.WriteLine(arr2.ToString());
          Console.WriteLine(arr0.Equals(arr1));
          Console.WriteLine(arr0.Equals(arr));
         
        
        
        }

    }



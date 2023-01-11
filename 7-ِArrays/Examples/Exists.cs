
using System.Collections;
using System.ComponentModel;
using System;
m;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
        int [] arr = {5, 2, 3, 1 ,0};
 Console.WriteLine("Check if element in the arr : " + Array.Exists( arr, item => item == 3));
 Console.WriteLine("Check if element in the arr : " + Array.Exists( arr, item => item == 9));
            
          


        }

    }

/*
Check if element in the arr : True
Check if element in the arr : False
*/

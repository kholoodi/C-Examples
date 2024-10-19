
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
        int [] arr = {5, 2, 3, 1 ,0};
	Console.WriteLine("Check if element in the arr : " + Array.Find( arr, item => item == 3));
	Console.WriteLine("Check if element in the arr : " + Array.Find( arr, item => item == 9));
            
          


        }

    }

/*
Check if element in the arr : 3
Check if element in the arr : 0
*/

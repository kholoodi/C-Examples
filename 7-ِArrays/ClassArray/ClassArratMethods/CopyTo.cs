
using System.Collections;
using System.ComponentModel;
using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
         int [] arr0 = {5, 2, 3, 1 ,0};
	int[] arr1 = {1, 2, 3, 4, 5};
	//Using CopyTo() method for copy arr0 to arr1 
	arr0.CopyTo(arr1,0);
	foreach(int value in arr1)
	    Console.Write(  value + " ");
        
        }
       
 }


/*
5 2 3 1 0 
*/
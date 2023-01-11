
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
        int [] arr0 = {5, 2, 3, 1 ,0};
	int [] arr1 = {2, 1,6 , 9, 8};
	//Sort the arr0
	Array.Sort(arr0);
	foreach(int value in arr0)
	    Console.Write(  value + " ");
	Console.WriteLine();
	//Reverse the arr0
	Array.Reverse(arr0);
	foreach(int value in arr0)
	    Console.Write(  value + " ");
	Console.WriteLine();
	//Reverse the arr1
	Array.Reverse(arr1);
	foreach(int value in arr1)
	    Console.Write(  value + " ");
        }

    }


/*
0 1 2 3 5 
5 3 2 1 0
8 9 6 1 2
*/
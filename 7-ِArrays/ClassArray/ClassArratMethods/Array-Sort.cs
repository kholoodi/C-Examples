
using System.Collections;
using System.ComponentModel;
using System;

    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
        int [] arr = {5, 2, 3, 1 ,0};
	Array.Sort(arr);
	foreach(int value in arr)
	    Console.Write(  value + " ");

        }

    }


/*
0 1 2 3 5

*/
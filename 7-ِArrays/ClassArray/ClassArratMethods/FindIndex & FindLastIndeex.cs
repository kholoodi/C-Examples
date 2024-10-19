
using System.Collections;
using System.ComponentModel;
using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
	int [] arr = {5, 2, 3, 1 ,0, 1};
	//Using FindIndex
	Console.WriteLine("Return  index of 3 : " + Array.FindIndex( arr, item => item == 3));
	Console.WriteLine("Return  index of 9 : " + Array.FindIndex( arr, item => item == 9));
	//Using FindLast 
	Console.WriteLine("Return last index of 1 : " + Array.FindLastIndex( arr, item => item == 1));
	Console.WriteLine("Return last index of 9 : " + Array.FindLastIndex( arr, item => item == 9));
          


        }

    }

/*
Return  index of 3 : 2
Return  index of 9 : -1
Return last index of 1 : 5
Return last index of 9 : -1
*/

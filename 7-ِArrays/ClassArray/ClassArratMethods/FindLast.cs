
using System.Collections;
using System.ComponentModel;
using System;

    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
        int [] arr = {5, 2, 3, 1 ,0, 1};
Console.WriteLine("Check if element in the arr  : " + Array.FindLast( arr, item => item == 1));
Console.WriteLine("Check if element in the arr : " + Array.FindLast( arr, item => item == 9));
        }

    }
/*
Check if element in the arr0  : 1
Check if element in the arr0 : 0
*/


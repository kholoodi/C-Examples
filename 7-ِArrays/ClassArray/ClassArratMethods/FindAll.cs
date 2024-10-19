
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
       int[] arr = {2, 9, 6 , 9, 8};
        //Return all matching  the elements
        int []array1 =  Array.FindAll( arr, item => item == 9);
        foreach(int value in array1)
        Console.Write(value +" ");
        }

    }



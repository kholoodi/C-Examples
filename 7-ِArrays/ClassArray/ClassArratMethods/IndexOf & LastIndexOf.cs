
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
	int [] arr = {5, 2, 3, 1 ,0, 1};
	//Using IndexOf 
	Console.WriteLine("Return  index of 1 : " +Array.IndexOf(arr, 1));
	Console.WriteLine("Return  index of 9 : " + Array.IndexOf(arr, 9));
	//Using LastIndexOf 
	Console.WriteLine("Return last index of 1 : " +Array.LastIndexOf(arr, 1));
	Console.WriteLine("Return last index of 9: " + Array.LastIndexOf(arr, 9));
          
      

        }

    }


/*

Return  index of 1 : 3
Return  index of 9 : -1
Return last index of 1 : 5
Return last index of 9: -1
*/

//using System.Collections;
//using System.ComponentModel;
//using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
    
        int[] arr1 = {1, 2, 3, 4, 5};
         // Two-dimensional array
        int[, ] arr2 = new int[, ] { { 1, 2 },{ 3, 4 },{ 5, 6 },{ 7, 8 } };
        
        // using Length property
        Console.WriteLine(arr1.Length);
         //using LongLength property

         Console.WriteLine(arr2.LongLength);
         // using Rank Property
        Console.WriteLine("Dimension of arr1 is: {0}\nDimension of arr1 is: {1}   " ,arr1.Rank , arr2.Rank) ;

        //check whether is array has  fixed size or not
        Console.WriteLine("Check the  fixed size property: " + arr1.IsFixedSize);

         // check whether is the  array  read only or not
        Console.WriteLine("Check the Read Only property: " + arr1.IsReadOnly);

        // check whether the array is synchronized (thread safe) or no
         Console.WriteLine(" Check the array has synchronized (thread safe): " + arr1.IsSynchronized);

         // Using the SyncRoot property
        lock(arr1.SyncRoot)
        {
            foreach(Object i in arr1)
            {
                Console.Write(i +"\t");
            }
        }
        
        }

    }

/*
5
8
Dimension of arr1 is: 1
Dimension of arr1 is: 2
Check the  fixed size property: True
check the Read Only property: False
 Check the array  synchronized (thread safe): False
1       2       3       4       5
*/

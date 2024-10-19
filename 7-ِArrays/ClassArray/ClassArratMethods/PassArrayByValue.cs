
using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
            //Careat and initialize firstArray
            int [] arrayValue = {1, 2, 3};
            //copy the reference in variable firstArray 
            int[] arrayValueCopy = arrayValue;
            Console.WriteLine("Test passing arrayValue by value");
            Console.Write("\ncontents of arrayValue before calling FirstDouble:\n\t");
            //display content of  firstArray 
            foreach(int i in arrayValue)
            Console.Write("{0} ", i);

            //Pass variable firstArray by value to FirstDouble
            DoubleArray(arrayValue);
            Console.Write("\ncontents of arrayValue after calling DoubleArray:\n\t");
            //display content of  firstArray 
             foreach(int i in arrayValue)
            Console.Write("{0} ", i);

            //test whether reference was changed by FirstDouble
            if ( arrayValue == arrayValueCopy)
            Console.WriteLine("\n\nThe references refers to the same array ");
            else
            Console.WriteLine("\n\nThe references refers to the different arrays ");
           
        }
        public static void DoubleArray( int[] array)
        {
            //Double each element by value 
            for (int i = 0; i < array.Length; i++)
            array[i] *= 2;
            //create new object and assign its reference to array 
            array = new int[] {11 , 12, 13};
            Console.Write("\n\nArray in the DoubleArray Method:\n\t");
            foreach(int i in array)
            Console.Write("{0} ", i);

        }

    }
/****************OutPut*********/
/*
Test passing arrayValue by value

contents of arrayValue before calling FirstDouble:
        1 2 3

Array in the DoubleArray Method:
        11 12 13
contents of arrayValue after calling DoubleArray:
        2 4 6

The references refers to the same array
*/



using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
            
            //Careat and initialize secondArray
            int [] ArrayRef = {1, 2, 3};

            //copy the reference in variable secondArray 
            int[] ArrayRefyCopy = ArrayRef;
            Console.WriteLine("\nTest passing ArrayRef reference by reference ");
            Console.Write("\ncontents of ArrayRef before calling DoubleArray:\n\t");
            //display content of  secondArray 
            foreach(int i in ArrayRef)
            Console.Write("{0} ", i);

            //Pass variable secondArray by reference to SecondDouble
            DoubleArray( ref ArrayRef);
            Console.Write("\ncontents of ArrayRef after calling DoubleArray:\n\t");
            //display content of secondArray  after method call
            foreach(int i in ArrayRef)
            Console.Write("{0} ", i);

            //test whether reference was changed by SecondDouble
            if ( ArrayRef == ArrayRefyCopy)
            Console.WriteLine("\n\nThe references refers to the same array ");
            else
            Console.WriteLine("\n\nThe references refers to the different arrays ");
        }
       
        public static void DoubleArray( ref int[] array)
        {
            //Double each element by value 
            for (int i = 0; i < array.Length; i++)
            array[i] *= 2;
            Console.Write("\n\nArray in the DoubleArray Method:\n\t");
            foreach(int i in array)
            Console.Write("{0} ", i);
            //create new object and assign its reference to array 
            array = new int[] {11 , 12, 13};
        }

    }


/*************Output**********/
/*
Test passing ArrayRef reference by reference

contents of ArrayRef before calling DoubleArray:
        1 2 3

Array in the DoubleArray Method:
        2 4 6 
contents of ArrayRef after calling DoubleArray:
        11 12 13

The references refers to the different arrays
*/
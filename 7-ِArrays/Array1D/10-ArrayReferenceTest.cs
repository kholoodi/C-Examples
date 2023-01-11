
using System;
    class ArrayReferenceTest
    {
        public static void Main(string[] args)
        {
            //Careat and initialize firstArray
            int [] firstArray = {1, 2, 3};
            //copy the reference in variable firstArray 
            int[] firstArrayCopy = firstArray;
            Console.WriteLine("Test passing firstArray by value");
            Console.Write("\ncontents of firstArray before calling FirstDouble:\n\t");
            //display content of  firstArray 
            for(int i =0 ; i < firstArray.Length; i++)
            Console.Write("{0} ", firstArray[i]);

            //Pass variable firstArray by value to FirstDouble
            FirstDouble(firstArray);
            Console.Write("\ncontents of firstArray after calling FirstDouble:\n\t");
            //display content of  firstArray 
            for(int i =0 ; i < firstArray.Length; i++)
            Console.Write("{0} ", firstArray[i]);

            //test whether reference was changed by FirstDouble
            if ( firstArray == firstArrayCopy)
            Console.WriteLine("\n\nThe references refers to the same array ");
            else
            Console.WriteLine("\n\nThe references refers to the different arrays ");
            //--------------------------------------
            //Careat and initialize secondArray
            int [] secondArray = {1, 2, 3};

            //copy the reference in variable secondArray 
            int[] secondArrayCopy = secondArray;
            Console.WriteLine("\nTest passing secondArray reference by reference ");
            Console.Write("\ncontents of secondArray before calling SecondDouble:\n\t");
            //display content of  secondArray 
            for(int i =0 ; i < secondArray.Length; i++)
            Console.Write("{0} ", secondArray[i]);

            //Pass variable secondArray by reference to SecondDouble
            SecondDouble( ref secondArray);
            Console.Write("\ncontents of secondArray after calling SecondDouble:\n\t");
            //display content of secondArray  after method call
            for(int i =0 ; i < secondArray.Length; i++)
            Console.Write("{0} ", secondArray[i]);

            //test whether reference was changed by SecondDouble
            if ( secondArray == secondArrayCopy)
            Console.WriteLine("\n\nThe references refers to the same array ");
            else
            Console.WriteLine("\n\nThe references refers to the different arrays ");
        }
        public static void FirstDouble( int[] array)
        {
            //Double each element by value 
            for (int i = 0; i < array.Length; i++)
            array[i] *= 2;
            //create new object and assign its reference to array 
            array = new int[] {11 , 12, 13};
        }
        public static void SecondDouble( ref int[] array)
        {
            //Double each element by value 
            for (int i = 0; i < array.Length; i++)
            array[i] *= 2;
            //create new object and assign its reference to array 
            array = new int[] {11 , 12, 13};
        }

    }

/*-----------------------output------------*/
/*
Test passing firstArray by value

contents of firstArray before calling FirstDouble:
	1 2 3 
contents of firstArray after calling FirstDouble:
	2 4 6 

The references refers to the same array 

Test passing secondArray reference by reference 

contents of secondArray before calling SecondDouble:
	1 2 3 
contents of secondArray after calling SecondDouble:
	11 12 13 

The references refers to the different arrays 

*/

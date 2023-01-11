
using System;
    class IntArray
    {
        public static void Main(string[] args)
        {
            int [] array ;  //declaring an  array named array.
            //create the spce for array an initialize to default zeros
            array = new int[10];    //10 int elements 
            Console.WriteLine("{0} {1,8}","index","value");
            //output each array element's value 
            for(int counter = 0; counter < array.Length; counter++)
            Console.WriteLine("{0,5} {1,8}", counter ,array[counter]);           
        }
    }




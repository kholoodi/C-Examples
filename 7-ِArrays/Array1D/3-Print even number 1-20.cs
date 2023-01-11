
using System;
    class IntArray
    {
        public static void Main(string[] args)
        {
           const int ARRAY_LENGTH = 10;     //create a named constant 
           int [] array = new int [ARRAY_LENGTH];   //Creat array
           //Calculate value for each array element  
            for(int counter = 0; counter < array.Length; counter++)
            array[counter] = 2 + 2 * counter;
            Console.WriteLine("{0}{1,8}", "Index", "Value") ; //heading 
              //output each array element's value 
            for(int counter = 0; counter < array.Length; counter++)
            Console.WriteLine("{0,5} {1,8}", counter ,array[counter]);      
        }
    }




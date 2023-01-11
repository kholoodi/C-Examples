
using System;
    class Program
    {
       
        public static void Main(string[] args)
        {
           // declaring and initializing an array with a specified value for each element
           int [] array = {1, 2 , 3};
           Array.Resize( ref array, 5); //resize the array length to 5
           Console.WriteLine("{0} {1,8}","index","value");
            for(int i = 0; i < array.Length; i++)
            Console.WriteLine("{0,5} {1,8}", i ,array[i]); 
            //Now resize the array length to 3 
            Array.Resize(ref array, 3);
             Console.WriteLine("{0} {1,8}","index","value");
            for(int i = 0; i < array.Length; i++)
            Console.WriteLine("{0,5} {1,8}", i ,array[i]);


            
        }   
    }


